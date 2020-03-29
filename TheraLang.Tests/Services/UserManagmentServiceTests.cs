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
using TheraLang.Tests.Mocks;
using Xunit;

namespace TheraLang.Tests.Services
{
    public class UserManagmentServiceTests
    {
        private readonly Mock<IUnitOfWork> _unitOfWorkMock;
        private readonly Mock<IFileService> _fileService;
        private readonly Mock<IConfirmationService> _confirmationService;
        private readonly UserManagementService _userService;
        private readonly RepositoryMock<User> _userRepoMock;
        private readonly RepositoryMock<UserDetails> _userDetailsRepoMock;
        private readonly RepositoryMock<Role> _roleRepoMock;
        private readonly RepositoryMock<UserConfirmation> _userConfirmationRepoMock;
        private List<User> usersTestData;

        public UserManagmentServiceTests()
        {
            usersTestData = GetUsersTestData().ToList();
            _userRepoMock = new RepositoryMock<User>(usersTestData);
            _userDetailsRepoMock = new RepositoryMock<UserDetails>(GetUserDetailsTestData().ToList());
            _roleRepoMock = new RepositoryMock<Role>(GetRolesTestData().ToList());
            _userConfirmationRepoMock = new RepositoryMock<UserConfirmation>(GetUserConfirmationsTestData().ToList());

            _unitOfWorkMock = new Mock<IUnitOfWork>();
            _unitOfWorkMock.Setup(u => u.Repository<User>()).Returns(_userRepoMock.Repository.Object);
            _unitOfWorkMock.Setup(u => u.Repository<Role>()).Returns(_roleRepoMock.Repository.Object);
            _unitOfWorkMock.Setup(u => u.Repository<UserDetails>()).Returns(_userDetailsRepoMock.Repository.Object);
            _unitOfWorkMock.Setup(u => u.Repository<UserConfirmation>()).Returns(_userConfirmationRepoMock.Repository.Object);
            _unitOfWorkMock.Setup(u => u.SaveChangesAsync()).Verifiable();
            _fileService = new Mock<IFileService>();
            _confirmationService = new Mock<IConfirmationService>();
            _confirmationService.Setup(x => x.SendEmail("", "", "")).Returns(Task.CompletedTask);

            _userService = new UserManagementService(_unitOfWorkMock.Object, _fileService.Object, _confirmationService.Object);
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
            User user = usersTestData.Where(u => u.Id == UserDefaultValues.DefaultId).FirstOrDefault();
            var result = await _userService.GetUserById(UserDefaultValues.DefaultId);
            result.Should().BeEquivalentTo(user);
        }

        [Fact]
        public async Task GetUserById_NotFound()
        {
            var result = await _userService.GetUserById(UserDefaultValues.FakeId);
            result.Should().BeNull();
        }

        [Fact]
        public async Task GetUser_NotFound()
        {
            var result = await _userService.GetUser(UserDefaultValues.FakeEmail, UserDefaultValues.DefaultString);
            result.Should().BeNull();
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

            Role role = new Role
            { 
                Id = UserDefaultValues.DefaultRoleId,
                Name = UserDefaultValues.DefaultRoleName
            };

            data.Add(new User()
            {
                Id = UserDefaultValues.DefaultId,
                Email = UserDefaultValues.DefaultEmail,
                PasswordHash = Common.Helpers.PasswordHelper.PasswordHasher.HashPassword(UserDefaultValues.DefaultString),
                RoleId = UserDefaultValues.DefaultRoleId,
                Role = role

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
