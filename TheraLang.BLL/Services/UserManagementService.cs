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
using System.Net;
using System.Net.Mail;
using Common.Configurations;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Hosting;

namespace TheraLang.BLL.Services
{
    public class UserManagementService : IUserManagementService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IFileService _fileService;
        private readonly EmailSettings _emailSettings;
        private readonly IHostingEnvironment _env;

        public UserManagementService(IUnitOfWork unitOfWork, IFileService fileService, IOptions<EmailSettings> emailSettings, IHostingEnvironment env)
        {
            _emailSettings = emailSettings.Value;
            _unitOfWork = unitOfWork;
            _fileService = fileService;
            _env = env;
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

                    _unitOfWork.Repository<UserDetails>().Add(userDetails);
                    _unitOfWork.Repository<User>().Add(user);

                    await _unitOfWork.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error when adding user ", ex);
            }
        }

        public async Task SendEmail(string ConfirmNum, string UserEmail)
        {
            string body = string.Empty;
            using (StreamReader reader =
            new StreamReader(Path.Combine(_env.ContentRootPath, "Templates", "welcome.html")))
            {
                body = await reader.ReadToEndAsync();
            }

            var fromAddress = new MailAddress(_emailSettings.Email, "UTMM");
            var toAddress = new MailAddress(UserEmail, "To User");
            string fromPassword = _emailSettings.Password;
            string subject = "Confirm your email";

            body = body.Replace("{EMAIL}", UserEmail);
            body = body.Replace("{NUMBER}", ConfirmNum);

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = true,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                IsBodyHtml = true,
                Body = body,
            })
            {
                await smtp.SendMailAsync(message);
            }
        }

        public async Task ConfirmUser(ConfirmUserDto confirmUser)
        {
            var user = await _unitOfWork.Repository<User>().Get(u => u.Email == confirmUser.Email);
            if (user.ConfirmationNumber.ToString() == confirmUser.ConfirmationNumber) user.RoleId = (await _unitOfWork.Repository<Role>().Get(r => r.Name == "Guest")).Id;
            _unitOfWork.Repository<User>().Update(user);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}