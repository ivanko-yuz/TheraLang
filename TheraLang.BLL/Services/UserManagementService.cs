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
using Common.Exceptions;

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
 
                var user = await _unitOfWork.Repository<User>().Get(u => u.Id == id);
                return user;

        }

        public async Task AddUser(UserAllDto newUser)
        {

                if (newUser != null)
                {
                    var mapper = new MapperConfiguration(cfg =>
                    {
                        cfg.CreateMap<UserAllDto, UserDetails>();
                        cfg.CreateMap<UserAllDto, User>();
                    }).CreateMapper();

                    var userDetails = mapper.Map<UserAllDto, UserDetails>(newUser);

                    if (newUser.Image != null)
                    {
                        var imageUri = await _fileService.SaveFile(newUser.Image.OpenReadStream(),
                            Path.GetExtension(newUser.Image.FileName));
                        userDetails.ImageURl = imageUri.ToString();
                    }

                    var user = mapper.Map<UserAllDto, User>(newUser);
                    user.RoleId = (await _unitOfWork.Repository<Role>().Get(r => r.Name == "Unconfirmed")).Id;
                    user.PasswordHash = PasswordHasher.HashPassword(newUser.Password);
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
                    await _confirmation.SendEmail(confUser.Number.ToString(), user.Email, "welcome.html");
                }
        }

        public async Task PasswordConfirmationRequest(string email)
        {

                var user = await _unitOfWork.Repository<User>().Get(u => u.Email == email);
                var conf = await _unitOfWork.Repository<UserConfirmation>().Get(u => u.Id == user.Id);
                Random rand = new Random();
                int random = rand.Next(10000000, 100000000);
                conf.Number = random;
                conf.ConfDateTime = DateTime.Now;
                await _unitOfWork.SaveChangesAsync();
                await _confirmation.SendEmail(random.ToString(), email, "password.html");
            }

        }

    }
}
