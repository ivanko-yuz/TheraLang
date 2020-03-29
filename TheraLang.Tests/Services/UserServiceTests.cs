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
    public class UserServiceTests
    {
        private readonly Mock<IUnitOfWork> _unitOfWorkMock;
        private readonly Mock<IFileService> _fileService;
        private readonly UserService _userService;
        private readonly RepositoryMock<User> _userRepoMock;
        private readonly RepositoryMock<UserDetails> _userDetailsRepoMock;
        private readonly RepositoryMock<Role> _roleRepoMock;

        public UserServiceTests()
        {
            _userRepoMock = new RepositoryMock<User>(GetUsersTestData().ToList());
            _userDetailsRepoMock = new RepositoryMock<UserDetails>(GetUserDetailsTestData().ToList());
            _roleRepoMock = new RepositoryMock<Role>(GetRolesTestData().ToList());
            _unitOfWorkMock = new Mock<IUnitOfWork>();
            _unitOfWorkMock.Setup(u => u.Repository<User>()).Returns(_userRepoMock.Repository.Object);
            _unitOfWorkMock.Setup(u => u.Repository<Role>()).Returns(_roleRepoMock.Repository.Object);
            _unitOfWorkMock.Setup(u => u.Repository<UserDetails>()).Returns(_userDetailsRepoMock.Repository.Object);
            _unitOfWorkMock.Setup(u => u.SaveChangesAsync()).Verifiable();
            _fileService = new Mock<IFileService>();
            _userService = new UserService(_unitOfWorkMock.Object, _fileService.Object);
        }

        [Fact]
        public async Task GetMyProfile_ShouldReturnMyProfile()
        {
            var result = await _userService.GetMyProfile(UserDefaultValues.DefaultId);
            result.Should().BeEquivalentTo(UserDefaultValues.myInfo);
        }

        [Fact]
        public async Task GetUserDetailsById_ShouldReturnUserDetails()
        {
            var result = await _userService.GetUserDetailsById(UserDefaultValues.DefaultId);
            result.Should().BeEquivalentTo(UserDefaultValues.detailsDto);
        }
        [Fact]
        public async Task GetUserDetailsById_ShouldReturnNull()
        {
            var result = await _userService.GetUserDetailsById(UserDefaultValues.FakeId);
            result.Should().BeNull();
        }

        [Fact]
        public async Task GetMyProfile_ShouldReturnNull()
        {
            var result = await _userService.GetMyProfile(UserDefaultValues.FakeId);
            result.Should().BeNull();
        }

        [Fact]
        public async Task GetAllUsers_ShouldReturnUsersListDto()
        {
            var result = await _userService.GetAllUsers(DefaultValues.PaginationParams);
            var expected = UserDefaultValues.usersListDto;
            result.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public async Task Update_ShouldCallSaveChanges()
        {
            await _userService.Update(UserDefaultValues.detailsDto, UserDefaultValues.DefaultId);
            _unitOfWorkMock.Verify(u => u.SaveChangesAsync(), Times.Once);
        }

        [Fact]
        public async Task Update_Exception()
        {
            Func<Task> result = async () => await _userService.Update(UserDefaultValues.detailsDto, UserDefaultValues.FakeId);
            await result.Should().ThrowAsync<Exception>();
        }

        [Fact]
        public async Task ChangeRole_ShouldCallSaveChanges()
        {
            await _userService.ChangeRole(UserDefaultValues.DefaultId, DefaultValues.Guid);
            _unitOfWorkMock.Verify(u => u.SaveChangesAsync(), Times.Once);
        }

        [Fact]
        public async Task ChangeRole_Exception()
        {
            Func<Task> result = async () => await _userService.ChangeRole(UserDefaultValues.FakeId, DefaultValues.FakeGuid);
            await result.Should().ThrowAsync<Exception>();
        }

        [Fact]
        public async Task AdminUserView_ShouldReturnAdminUserViewDto()
        {
            var result = await _userService.AdminUserView(UserDefaultValues.DefaultId);
            result.Should().BeEquivalentTo(UserDefaultValues.userViewDto);
        }

        [Fact]
        public async Task AdminUserView_Exception()
        {
            Func<Task> result = async () => await _userService.AdminUserView(UserDefaultValues.FakeId);
            await result.Should().ThrowAsync<NullReferenceException>();
        }


        [Fact]
        public async Task GetUserRole_ShouldReturnRole()
        {
            var result = await _userService.GetUserRole(UserDefaultValues.DefaultId);
            result.Should().Be(UserDefaultValues.DefaultRoleId);
        }

        [Fact]
        public async Task GetUserRole_Exception()
        {
            Func<Task> result = async () => await _userService.GetUserRole(UserDefaultValues.FakeId);
            await result.Should().ThrowAsync<Exception>();
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
    }
}

