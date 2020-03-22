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
    public class UserServiceTests
    {
        private readonly Mock<IUnitOfWork> _unitOfWorkMock;
        private readonly Mock<IFileService> _fileService;
        private readonly UserService _userService;
        private readonly List<User> _testUsersDb;
        private readonly List<Role> _testRolesDb;
        private readonly List<UserDetails> _testUserDetailsDb;

        public UserServiceTests()
        {
            _testUsersDb = GetUsersTestData().ToList();
            _testRolesDb = GetRolesTestData().ToList();
            _testUserDetailsDb = GetUserDetailsTestData().ToList();

            var userRepoMock = new Mock<IRepository<User>>();
            var userDetailsRepoMock = new Mock<IRepository<UserDetails>>();
            var roleRepoMock = new Mock<IRepository<Role>>();

            userRepoMock.Setup(r => r.GetAll()).Returns(_testUsersDb.AsQueryable().BuildMock().Object);
            userRepoMock.Setup(r => r.Get(It.IsAny<Expression<Func<User, bool>>>()))
                 .ReturnsAsync((Expression<Func<User, bool>> predicate) => _testUsersDb
                 .AsQueryable()
                 .Where(predicate)
                 .FirstOrDefault());
            userRepoMock.Setup(r => r.Add(It.IsAny<User>()))
                .Callback((User user) =>
                {
                    _testUsersDb.Add(user);
                });

            roleRepoMock.Setup(r => r.Get(It.IsAny<Expression<Func<Role, bool>>>()))
                .ReturnsAsync((Expression<Func<Role, bool>> predicate) => _testRolesDb
                .AsQueryable()
                .Where(predicate)
                .FirstOrDefault());
            roleRepoMock.Setup(r => r.Add(It.IsAny<Role>()))
                .Callback((Role role) =>
                {
                    _testRolesDb.Add(role);
                });
            roleRepoMock.Setup(r => r.GetAll()).Returns(_testRolesDb.AsQueryable().BuildMock().Object);
            roleRepoMock.Setup(r => r.GetAllAsync()).ReturnsAsync(_testRolesDb.AsQueryable().BuildMock().Object);

            userDetailsRepoMock.Setup(r => r.GetAll()).Returns(_testUserDetailsDb.AsQueryable().BuildMock().Object);
            userDetailsRepoMock.Setup(r => r.Get(It.IsAny<Expression<Func<UserDetails, bool>>>()))
                .ReturnsAsync((Expression<Func<UserDetails, bool>> predicate) => _testUserDetailsDb
                .AsQueryable()
                .Where(predicate)
                .FirstOrDefault());
            userDetailsRepoMock.Setup(r => r.Add(It.IsAny<UserDetails>()))
                .Callback((UserDetails details) =>
                {
                    _testUserDetailsDb.Add(details);

                });
            _unitOfWorkMock = new Mock<IUnitOfWork>();
            _unitOfWorkMock.Setup(u => u.Repository<User>()).Returns(userRepoMock.Object);
            _unitOfWorkMock.Setup(u => u.Repository<Role>()).Returns(roleRepoMock.Object);
            _unitOfWorkMock.Setup(u => u.Repository<UserDetails>()).Returns(userDetailsRepoMock.Object);
            _unitOfWorkMock.Setup(u => u.SaveChangesAsync()).Verifiable();
            _fileService = new Mock<IFileService>();
            _userService = new UserService(_unitOfWorkMock.Object, _fileService.Object);
        }

        [Fact]
        public async Task GetMyProfile_ShouldReturnMyProfile()
        {
            var testGuid = UserDefaultValues.myInfo.Id;
            var user = new User
            {
                Id = testGuid,
                Email = UserDefaultValues.myInfo.Email,
            };
            var userDetails = new UserDetails
            {
                UserDetailsId = testGuid,
                FirstName = UserDefaultValues.myInfo.FirstName,
                LastName = UserDefaultValues.myInfo.LastName,
                User = user
            };

            _testUsersDb.Add(user);
            _testUserDetailsDb.Add(userDetails);
            var result = await _userService.GetMyProfile(testGuid);
            result.Should().BeEquivalentTo(UserDefaultValues.myInfo);
        }

        [Fact]
        public async Task GetUserDetailsById_ShouldReturnUserDetails()
        {
            var testGuid = new Guid("507f77df-fd1c-48c5-9900-f7ace8c250f7");

            var user = new UserDetails
            {
                UserDetailsId = testGuid,
                FirstName = UserDefaultValues.detailsDto.FirstName,
                LastName = UserDefaultValues.detailsDto.LastName,
                PhoneNumber = UserDefaultValues.detailsDto.PhoneNumber,
                City = UserDefaultValues.detailsDto.City,
            };

            _testUserDetailsDb.Add(user);

            var result = await _userService.GetUserDetailsById(testGuid);
            result.Should().BeEquivalentTo(UserDefaultValues.detailsDto);
        }
        [Fact]
        public async Task GetUserDetailsById_ShouldReturnNull()
        {
            var result = await _userService.GetUserDetailsById(DefaultValues.FakeGuid);
            result.Should().BeNull();
        }

        [Fact]
        public async Task GetMyProfile_ShouldReturnNull()
        {
            var result = await _userService.GetMyProfile(DefaultValues.FakeGuid);
            result.Should().BeNull();
        }

        [Fact]
        public async Task GetAllUsers_ShouldReturnUsersListDto()
        {
            var userNumOne = new UserDetails { FirstName = "FirstName", LastName = "LastName", City = "city" };
            _testUserDetailsDb.Add(userNumOne);
            var userNumTwo = new UserDetails { FirstName = "Andriana", LastName = "Baran", ShortInformation = "info" };
            _testUserDetailsDb.Add(userNumTwo);

            var result = await _userService.GetAllUsers(DefaultValues.PaginationParams);
            var expected = UserDefaultValues.usersListDto;
            result.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public async Task Update_ShouldCallSaveChanges()
        {
            var testGuid = new Guid("117f72d1-fd1c-48c5-9900-f7ace8c25111");
            var user = new UserDetails
            {
                UserDetailsId = testGuid,
                FirstName = "Andriana",
                LastName = "Andruhana",
                PhoneNumber = "3809459043",
                City = "Lviv",
            };
            _testUserDetailsDb.Add(user);
            await _userService.Update(UserDefaultValues.detailsDto, testGuid);
            _unitOfWorkMock.Verify(u => u.SaveChangesAsync(), Times.Once);
        }

        [Fact]
        public async Task Update_Exception()
        {
            Func<Task> result = async () => await _userService.Update(UserDefaultValues.detailsDto, DefaultValues.FakeGuid);
            await result.Should().ThrowAsync<Exception>();
        }

        [Fact]
        public async Task ChangeRole_ShouldCallSaveChanges()
        {
            var testGuid = new Guid("8a5593e3-011d-46ed-9e0d-3a1f096861e7");
            var user = new User
            {
                Id = testGuid,
                Email = "andrianabaran@gmail.com",
                RoleId = new Guid("117f7444-f22c-28c5-9900-f7ace8c25111")
            };
            _testUsersDb.Add(user);
            await _userService.ChangeRole(testGuid, DefaultValues.Guid);
            _unitOfWorkMock.Verify(u => u.SaveChangesAsync(), Times.Once);
        }

        [Fact]
        public async Task ChangeRole_Exception()
        {
            Func<Task> result = async () => await _userService.ChangeRole(DefaultValues.Guid, DefaultValues.FakeGuid);
            await result.Should().ThrowAsync<Exception>();
        }

        [Fact]
        public async Task AdminUserView_ShouldReturnAdminUserViewDto()
        {
            var testGuid = new Guid("117f72d1-fd1c-48c5-9900-f7ace8c25111");
            var roleGuid = new Guid("f87f6e71-f3ed-4796-a1bb-5b91a82c4b8b");
            var role = new Role
            {
                Id = roleGuid,
                Name = "Admin"
            };
            _testRolesDb.Add(role);
            var user = new User
            {
                Id = testGuid,
                RoleId = roleGuid,
                Email = "andriana@gmail.com"
            };
            _testUsersDb.Add(user);
            var userDetails = new UserDetails
            {
                UserDetailsId = testGuid,
                FirstName = "Andriana",
                LastName = "Baran",
                ShortInformation = "Info",
                User = user
            };
            _testUserDetailsDb.Add(userDetails);
            var result = await _userService.AdminUserView(testGuid);
            result.Should().BeEquivalentTo(UserDefaultValues.userViewDto);
        }

        [Fact]
        public async Task AdminUserView_Exception()
        {
            Func<Task> result = async () => await _userService.AdminUserView(DefaultValues.FakeGuid);
            await result.Should().ThrowAsync<NullReferenceException>();
        }


        [Fact]
        public async Task GetUserRole_ShouldReturnRole()
        {
            var userId = new Guid("a472335d-cf45-45f7-aebf-7bd3bdfa7cb8");
            var roleId = new Guid("22dcda25-8ffe-40d1-8332-7355d06c7ec0");

            var user = new User
            {
                Id = userId,
                Email = "andrianabaran@gmail.com",
                RoleId = roleId,
            };
            _testUsersDb.Add(user);
            var result = await _userService.GetUserRole(userId);
            result.Should().Be(roleId);
        }

        [Fact]
        public async Task GetUserRole_Exception()
        {
            Func<Task> result = async () => await _userService.GetUserRole(DefaultValues.FakeGuid);
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
            return data.AsEnumerable();
        }
    }
}
