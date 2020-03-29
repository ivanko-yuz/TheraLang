using FluentAssertions;
using MockQueryable.Moq;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using TheraLang.BLL.Services;
using TheraLang.DAL.Entities;
using TheraLang.DAL.Repository;
using TheraLang.DAL.UnitOfWork;
using TheraLang.Tests.DataBuilders.ResourcesBuilders;
using Xunit;
using Microsoft.AspNetCore.Hosting;
using Common.Configurations;
using Common.Helpers.PasswordHelper;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;
using TheraLang.Tests.Mocks;

namespace TheraLang.Tests.Services
{
   public class ConfirmationServiceTests
    {
        private readonly Mock<IUnitOfWork> _unitOfWorkMock;
        private readonly ConfirmationService _confirmationService;
        private readonly Mock<ISendGridClient> _sendGridMock;
        private readonly RepositoryMock<User> _userRepoMock;
        private readonly RepositoryMock<UserDetails> _userDetailsRepoMock;
        private readonly RepositoryMock<Role> _roleRepoMock;
        private readonly RepositoryMock<UserConfirmation> _userConfirmationRepoMock;

        public ConfirmationServiceTests()
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

        [Fact]
        public async Task SendEmail_ShouldSendEmail()
        {
            await _confirmationService.SendEmail(UserDefaultValues.DefaultConfirmNum, UserDefaultValues.DefaultEmail, UserDefaultValues.DefaultPathTo);
            _sendGridMock.Verify(x => x.SendEmailAsync(It.IsAny<SendGridMessage>(), CancellationToken.None), Times.Once);
        }

        [Fact]
        public async Task ConfirmUser_ShouldChangeRole()
        {
            await _confirmationService.ConfirmUser(UserDefaultValues.ConfirmUser);
            _unitOfWorkMock.Verify(u => u.SaveChangesAsync(), Times.Once);
        }

        [Fact]
        public async Task ConfirmUser_Exception()
        {
            Func<Task> result = async () => await _confirmationService.ConfirmUser(UserDefaultValues.FakeConfirnmation);
            await result.Should().ThrowAsync<NullReferenceException>();
        }

        [Fact]
        public async Task ConfirmPassword_ShouldChangePassword()
        {
            await _confirmationService.ConfirmPassword(UserDefaultValues.confirmPasswordChanging);
            _unitOfWorkMock.Verify(u => u.SaveChangesAsync(), Times.Once);
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
