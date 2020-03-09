using System;
using System.IO;
using System.Threading.Tasks;
using AutoMapper;
using Common.Helpers.PasswordHelper;
using Microsoft.EntityFrameworkCore;
using TheraLang.BLL.DataTransferObjects.UserDtos;
using TheraLang.BLL.Interfaces;
using TheraLang.DAL.Entities;
using TheraLang.DAL.UnitOfWork;
using Common.Configurations;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Hosting;

namespace TheraLang.BLL.Services
{
    public class UserManagementService : IUserManagementService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IFileService _fileService;
        private readonly IConfirmationService _confirmation;

        public UserManagementService(IUnitOfWork unitOfWork, IFileService fileService, IConfirmationService confirmation)
        {
            _unitOfWork = unitOfWork;
            _fileService = fileService;
            _confirmation = confirmation;
        }


        public async Task<User> GetUser(string email, string password)
        {
            var user = await _unitOfWork.Repository<User>().GetAll().Include(x => x.Role)
                .FirstOrDefaultAsync(u => u.Email == email);
            if (PasswordHasher.VerifyHashedPassword(user.PasswordHash, password))
            {
                return user;
            }

            throw new Exception($"Cannot get user with {nameof(email)}: {email}.");
        }

        public async Task<User> GetUserById(Guid id)
        {
            try
            {
                var user = await _unitOfWork.Repository<User>().Get(u => u.Id == id);
                return user;
            }
            catch (Exception ex)
            {
                throw new Exception($"Cannot get project with {nameof(id)}: {id}.", ex);
            }
        }

        public async Task AddUser(UserAllDto NewUser)
        {
            try
            {
                if (NewUser != null)
                {
                    var mapper = new MapperConfiguration(cfg =>
                    {
                        cfg.CreateMap<UserAllDto, UserDetails>();
                        cfg.CreateMap<UserAllDto, User>();
                    }).CreateMapper();

                    var userDetails = mapper.Map<UserAllDto, UserDetails>(NewUser);

                    if (NewUser.Image != null)
                    {
                        var imageUri = await _fileService.SaveFile(NewUser.Image.OpenReadStream(),
                            Path.GetExtension(NewUser.Image.FileName));
                        userDetails.ImageURl = imageUri.ToString();
                    }

                    var user = mapper.Map<UserAllDto, User>(NewUser);
                    user.RoleId = (await _unitOfWork.Repository<Role>().Get(r => r.Name == "Unconfirmed")).Id;
                    user.PasswordHash = PasswordHasher.HashPassword(NewUser.Password);
                    user.Details = userDetails;
                    Random rand = new Random();
                    int random = rand.Next(10000000, 100000000);

                    var confUser = new UserConfirmation()
                    {
                        Number = random,
                        ConfDateTime = DateTime.Now
                    };

                    user.Confirmation = confUser;

                    _unitOfWork.Repository<UserDetails>().Add(userDetails);
                    _unitOfWork.Repository<User>().Add(user);
                    _unitOfWork.Repository<UserConfirmation>().Add(confUser);

                    await _unitOfWork.SaveChangesAsync();
                    await _confirmation.SendEmail(confUser.Number.ToString(), user.Email);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error when adding user ", ex);
            }
        }

        public async Task PasswordConfirmationRequest(string Email)
        {
            try
            {
                var user = await _unitOfWork.Repository<User>().Get(u => u.Email == Email);
                var conf = await _unitOfWork.Repository<UserConfirmation>().Get(u => u.Id == user.Id);
                Random rand = new Random();
                int random = rand.Next(10000000, 100000000);
                conf.Number = random;
                conf.ConfDateTime = DateTime.Now;
                await _unitOfWork.SaveChangesAsync();
                await _confirmation.SendEmail(random.ToString(), Email);
            }
            catch (Exception ex)
            {
                throw new Exception("Error when sending email ", ex);
            }
        }

    }
}
