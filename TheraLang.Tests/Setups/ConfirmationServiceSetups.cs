using Common.Configurations;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Options;
using Moq;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TheraLang.BLL.Interfaces;
using TheraLang.BLL.Services;
using TheraLang.DAL.Entities;
using TheraLang.DAL.UnitOfWork;
using TheraLang.Tests.DataBuilders.ResourcesBuilders;
using TheraLang.Tests.Mocks;

namespace TheraLang.Tests.Setups
{
    public class ConfirmationServiceSetups
    {
        protected readonly Mock<IUnitOfWork> _unitOfWorkMock;
        protected readonly ConfirmationService _confirmationService;
        protected readonly Mock<ISendGridClient> _sendGridMock;
        protected readonly RepositoryMock<User> _userRepoMock;
        protected readonly RepositoryMock<UserDetails> _userDetailsRepoMock;
        protected readonly RepositoryMock<Role> _roleRepoMock;
        protected readonly RepositoryMock<UserConfirmation> _userConfirmationRepoMock;
        public ConfirmationServiceSetups()
        {
            _userRepoMock = new RepositoryMock<User>(GetUsersTestData().ToList());
            _userDetailsRepoMock = new RepositoryMock<UserDetails>(GetUserDetailsTestData().ToList());
            _roleRepoMock = new RepositoryMock<Role>(GetRolesTestData().ToList());
            _userConfirmationRepoMock = new RepositoryMock<UserConfirmation>(GetUserConfirmationsTestData().ToList());
            _unitOfWorkMock = new Mock<IUnitOfWork>();
            _unitOfWorkMock.Setup(u => u.Repository<User>()).Returns(_userRepoMock.Repository.Object);
            _unitOfWorkMock.Setup(u => u.Repository<UserDetails>()).Returns(_userDetailsRepoMock.Repository.Object);
            _unitOfWorkMock.Setup(u => u.Repository<Role>()).Returns(_roleRepoMock.Repository.Object);
            _unitOfWorkMock.Setup(u => u.Repository<UserConfirmation>()).Returns(_userConfirmationRepoMock.Repository.Object);
            _unitOfWorkMock.Setup(u => u.SaveChangesAsync()).Verifiable();
            var mockEnvironment = new Mock<IHostingEnvironment>();
            mockEnvironment.SetupAllProperties();
            mockEnvironment.Setup(m => m.ContentRootPath).Returns("");
            mockEnvironment.Setup(m => m.EnvironmentName).Returns("TEST");
            var _emailSettings = Options.Create(new EmailSettings());
            _sendGridMock = new Mock<ISendGridClient>();
            _sendGridMock.SetupAllProperties();
            var response = new Response(System.Net.HttpStatusCode.OK, null, null);
            _sendGridMock.Setup(x => x.SendEmailAsync(It.IsAny<SendGridMessage>(), CancellationToken.None)).Returns(Task.FromResult(response));
            _confirmationService = new ConfirmationService(mockEnvironment.Object, _unitOfWorkMock.Object, _emailSettings, _sendGridMock.Object);
        }
        private IEnumerable<User> GetUsersTestData()
        {
            var data = new List<User>();

            for (int i = 0; i < DefaultValues.ListSize; i++)
            {
                var dataBuilder = new UserTestBuilder();
                data.Add(dataBuilder
                    .WithId(new Guid())
                    .WithDefault()
                    .Build());
            }
            data.Add(new User()
            {
                Id = UserDefaultValues.DefaultId,
                Email = UserDefaultValues.DefaultEmail,
                PasswordHash = UserDefaultValues.DefaultString,
                RoleId = UserDefaultValues.DefaultRoleId,

            });
            return data.AsEnumerable();
        }
        private IEnumerable<Role> GetRolesTestData()
        {
            var data = new List<Role>();

            data.Add(new Role()
            {
                Id = Guid.NewGuid(),
                Name = "Guest",
            });
            data.Add(new Role()
            {
                Id = UserDefaultValues.DefaultRoleId,
                Name = UserDefaultValues.DefaultRoleName
            });

            return data.AsEnumerable();
        }

        private IEnumerable<UserDetails> GetUserDetailsTestData()
        {
            var user = new User()
            {
                Id = UserDefaultValues.DefaultId,
                Email = UserDefaultValues.DefaultEmail
            };
            var data = new List<UserDetails>();
            data.Add(new UserDetails()
            {
                UserDetailsId = UserDefaultValues.DefaultId,
                FirstName = UserDefaultValues.DefaultString,
                LastName = UserDefaultValues.DefaultString,
                City = UserDefaultValues.DefaultString,
                PhoneNumber = UserDefaultValues.DefaultString,
                ShortInformation = UserDefaultValues.DefaultString,
                BirthDay = UserDefaultValues.DefaultBirthDate,
                User = user,
            });
            return data.AsEnumerable();
        }

        private IEnumerable<UserConfirmation> GetUserConfirmationsTestData()
        {
            var data = new List<UserConfirmation>();
            data.Add(new UserConfirmation()
            {
                Id = UserDefaultValues.DefaultId,
                Number = Int32.Parse(UserDefaultValues.DefaultConfirmNum),
                ConfDateTime = DateTime.Now
            });

            return data.AsEnumerable();
        }
    }
}
