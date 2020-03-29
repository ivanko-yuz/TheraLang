using Common.Helpers.PasswordHelper;
using FluentAssertions;
using MockQueryable.Moq;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TheraLang.BLL.Interfaces;
using TheraLang.BLL.Services;
using TheraLang.DAL.Entities;
using TheraLang.DAL.Repository;
using TheraLang.DAL.UnitOfWork;
using TheraLang.Tests.DataBuilders.ResourcesBuilders;
using Xunit;

namespace TheraLang.Tests.Services
{
    public class UserManagmentServiceTests
    {
        private readonly Mock<IUnitOfWork> _unitOfWorkMock;
        private readonly Mock<IFileService> _fileService;
        private readonly Mock<IConfirmationService> _confirmationService;
        private readonly UserManagementService _userService;
        private readonly List<User> _testUsersDb;
        private readonly List<Role> _testRolesDb;
        private readonly List<UserDetails> _testUserDetailsDb;
        private readonly List<UserConfirmation> _testUserConfirmationsDb;
         
        public UserManagmentServiceTests()
        {
            _testUsersDb = GetUsersTestData().ToList();
            _testRolesDb = GetRolesTestData().ToList();
            _testUserDetailsDb = GetUserDetailsTestData().ToList();
            _testUserConfirmationsDb = GetUserConfirmationsTestData().ToList();

            var userRepoMock = new Mock<IRepository<User>>();
            var userDetailsRepoMock = new Mock<IRepository<UserDetails>>();
            var roleRepoMock = new Mock<IRepository<Role>>();
            var userConfirmationRepoMock = new Mock<IRepository<UserConfirmation>>();
            userRepoMock.Setup(r => r.GetAll()).Returns(_testUsersDb.AsQueryable().BuildMock().Object);
            userRepoMock.Setup(r => r.Get(It.IsAny<Expression<Func<User, bool>>>()))
                .ReturnsAsync((Expression<Func<User, bool>> predicate) => _testUsersDb
                    .AsQueryable()
                    .Where(predicate)
                    .FirstOrDefault());
            userRepoMock.Setup(r => r.Add(It.IsAny<User>()))
                .Callback((User user) =>
                {
                    user.Id = new Guid();
                    _testUsersDb.Add(user);
                });

            roleRepoMock.Setup(r => r.Get(It.IsAny<Expression<Func<Role, bool>>>()))
                .ReturnsAsync((Expression<Func<Role, bool>> predicate) => _testRolesDb
                    .AsQueryable()
                    .Where(predicate)
                    .FirstOrDefault());

            userDetailsRepoMock.Setup(r => r.Add(It.IsAny<UserDetails>()))
                .Callback((UserDetails details) =>
                {
                    _testUserDetailsDb.Add(details);
                   
                });

            userConfirmationRepoMock.Setup(r => r.Add(It.IsAny<UserConfirmation>()))
                .Callback((UserConfirmation confirmation) =>
                {
                    _testUserConfirmationsDb.Add(confirmation);
                });

            userConfirmationRepoMock.Setup(r => r.Get(It.IsAny<Expression<Func<UserConfirmation, bool>>>()))
               .ReturnsAsync((Expression<Func<UserConfirmation, bool>> predicate) => _testUserConfirmationsDb
                   .AsQueryable()
                   .Where(predicate)
                   .FirstOrDefault());

            _unitOfWorkMock = new Mock<IUnitOfWork>();
            _unitOfWorkMock.Setup(u => u.Repository<User>()).Returns(userRepoMock.Object);
            _unitOfWorkMock.Setup(u => u.Repository<Role>()).Returns(roleRepoMock.Object);
            _unitOfWorkMock.Setup(u => u.Repository<UserDetails>()).Returns(userDetailsRepoMock.Object);
            _unitOfWorkMock.Setup(u => u.Repository<UserConfirmation>()).Returns(userConfirmationRepoMock.Object);
            _unitOfWorkMock.Setup(u => u.SaveChangesAsync()).Verifiable();
            _fileService = new Mock<IFileService>();
            _confirmationService = new Mock<IConfirmationService>();
            _confirmationService.Setup(x => x.SendEmail("", "", "")).Returns(Task.CompletedTask);

            _userService = new UserManagementService(_unitOfWorkMock.Object, _fileService.Object, _confirmationService.Object);
        }

        [Fact]
        public async Task GetUser_ShouldReturnUser()
        {
            var email = "email@gmail.com";
            var password = PasswordHasher.HashPassword("password");
            var user = new User
            {
                Id = new Guid("507f77df-fd1c-48c5-9900-f7ace8c250f7"),
                Email = email,
                PasswordHash = password,
                RoleId = new Guid()
            };
            _testUsersDb.Add(user);
            var result = await _userService.GetUser(email, "password");
            result.Should().BeEquivalentTo(user);
        }

        [Fact]
        public async Task AddUser_ShouldCallSaveChanges()
        {
            await _userService.AddUser(UserDefaultValues.userAll);
            _unitOfWorkMock.Verify(u => u.SaveChangesAsync(), Times.AtLeastOnce);
        }

        [Fact]
        public async Task AddConfirmation_ShouldReturnConfirmationUser()
        { 
             await _userService.AddConfirmation(UserDefaultValues.DefaultId);
            _unitOfWorkMock.Verify(u => u.SaveChangesAsync(), Times.Once);
        }

        [Fact]
        public async Task GetUserById_ShouldReturnUser()
        {
            var testGuid = new Guid("507f77df-fd1c-48c5-9900-f7ace8c250f7");
            var user = new User
            {
                Id = testGuid,
                Email = "andriana@gmail.com",
                PasswordHash = "password",
                RoleId = new Guid()
            };
            _testUsersDb.Add(user);
            var result = await _userService.GetUserById(testGuid);
            result.Should().BeEquivalentTo(user);
        }

        [Fact]
        public async Task GetUserById_NotFound()
        {
            var result = await _userService.GetUserById(UserDefaultValues.FakeId);
            result.Should().BeNull();
        }

        [Fact]
        public async Task GetUser_Exception()
        {
            Func<Task> result = async () => await _userService.GetUser(UserDefaultValues.FakeEmail, UserDefaultValues.DefaultString);
            await result.Should().ThrowAsync<Exception>();
        }

        [Fact]
        public async Task PasswordConfirmationRequest_ShouldCallSaveChanges()
        {
            await _userService.PasswordConfirmationRequest(UserDefaultValues.DefaultEmail);
            _unitOfWorkMock.Verify(u => u.SaveChangesAsync(), Times.Once);
        }

        [Fact]
        public async Task PasswordConfirmationRequest_Exception()
        {
            Func<Task> result = async () => await _userService.PasswordConfirmationRequest(UserDefaultValues.FakeEmail);
            await result.Should().ThrowAsync<NullReferenceException>();
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
                Name = "Unconfirmed",
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
            var data = new List<UserDetails>();
            data.Add(new UserDetails()
            {
                UserDetailsId = UserDefaultValues.DefaultId,
                FirstName = UserDefaultValues.DefaultString,
                LastName = UserDefaultValues.DefaultString,
                City = UserDefaultValues.DefaultString,
                PhoneNumber = UserDefaultValues.DefaultString,
                ShortInformation = UserDefaultValues.DefaultString,
                BirthDay = UserDefaultValues.DefaultBirthDate
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
