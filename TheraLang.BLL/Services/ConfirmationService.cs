using Microsoft.AspNetCore.Hosting;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using TheraLang.DAL.UnitOfWork;
using TheraLang.DAL.Entities;
using TheraLang.BLL.DataTransferObjects.UserDtos;
using Common.Configurations;
using Microsoft.Extensions.Options;
using TheraLang.BLL.Interfaces;
using Common.Helpers.PasswordHelper;

namespace TheraLang.BLL.Services
{
    public class ConfirmationService: IConfirmationService
    {
        private readonly IHostingEnvironment _env;
        private readonly IUnitOfWork _unitOfWork;
        private readonly EmailSettings _emailSettings;
        private readonly SmtpClient _smtpClient;

        public ConfirmationService(IHostingEnvironment env, IUnitOfWork unitOfWork, IOptions<EmailSettings> emailSettings)
        {
            _env = env;
            _unitOfWork = unitOfWork;
            _emailSettings = emailSettings.Value;
            _smtpClient = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = true,
                Credentials = new NetworkCredential(new MailAddress(_emailSettings.Email, "UTTMM").Address, _emailSettings.Password)
            };
        }


        public async Task SendEmail(string ConfirmNum, string UserEmail, string PathTo)
        {
            string body = string.Empty;
            using (StreamReader reader =
            new StreamReader(Path.Combine(_env.ContentRootPath, "Templates", PathTo)))
            {
                body = await reader.ReadToEndAsync();
            }

            var fromAddress = new MailAddress(_emailSettings.Email, "UTTMM");
            var toAddress = new MailAddress(UserEmail, "To User");
            string fromPassword = _emailSettings.Password;
            string subject = "UTTMM";

            var user = await _unitOfWork.Repository<UserDetails>().Get(u => u.User.Email == UserEmail);
            var url = "https://theralang.azurewebsites.net";
            if (_env.IsDevelopment())
            {
                url = "http://localhost:5000";
            }

            body = body.Replace("{EMAIL}", UserEmail);
            body = body.Replace("{NUMBER}", ConfirmNum);
            body = body.Replace("{FIRSTNAME}", user.FirstName);
            body = body.Replace("{URL}", url);
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                IsBodyHtml = true,
                Body = body,
            })
            {
                await _smtpClient.SendMailAsync(message);
            }
        }

        public async Task ConfirmUser(ConfirmUserDto confirmUser)
        {
            var user = await _unitOfWork.Repository<User>().Get(u => u.Email == confirmUser.Email);
            var conf = await _unitOfWork.Repository<UserConfirmation>().Get(u => u.Id == user.Id);
            if (confirmUser.ConfirmationNumber == conf.Number.ToString() && conf.ConfDateTime <= DateTime.Now.AddMinutes(30)) user.RoleId = (await _unitOfWork.Repository<Role>().Get(r => r.Name == "Guest")).Id;
            _unitOfWork.Repository<User>().Update(user);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task ConfirmPassword (ConfirmPasswordChangingDto confirmUser)
        {
            var user = await _unitOfWork.Repository<User>().Get(u => u.Email == confirmUser.Email);
            var conf = await _unitOfWork.Repository<UserConfirmation>().Get(u => u.Id == user.Id);
            if (confirmUser.ConfirmationNumber == conf.Number.ToString() && conf.ConfDateTime <= DateTime.Now.AddMinutes(30))
            {
                user.PasswordHash = PasswordHasher.HashPassword(confirmUser.Password);
                await _unitOfWork.SaveChangesAsync();
            }
        }
    }
}
