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
            var testGuid = DefaultValues.myInfo.Id;
            var user = new User
            {
                Id = testGuid,
                Email = DefaultValues.myInfo.Email,
                //PasswordHash = PasswordHasher.HashPassword(DefaultValues.userAll.Password)
            };
            var userDetails = new UserDetails
            {
                UserDetailsId = testGuid,
                FirstName = DefaultValues.myInfo.FirstName,
                LastName = DefaultValues.myInfo.LastName,
                User = user
            };

            _testUsersDb.Add(user);
            _testUserDetailsDb.Add(userDetails);
            var result = await _userService.GetMyProfile(testGuid);
            result.Should().BeEquivalentTo(DefaultValues.myInfo);
        }

        [Fact]
        public async Task GetMyProfile_Exception()
        {
            var testGuid = new Guid("507f77df-fd1c-48c5-9940-12ace8c250f7");
            Func<Task> result = async () => await _userService.GetMyProfile(testGuid);
            result.Should().BeNull();
        }

        [Fact]
        public async Task GetUserDetailsById_ShouldReturnUserDetails()
        {
            var testGuid = new Guid("507f77df-fd1c-48c5-9900-f7ace8c250f7");

            var user = new UserDetails
            {
                UserDetailsId = testGuid,
                FirstName = DefaultValues.detailsDto.FirstName,
                LastName = DefaultValues.detailsDto.LastName,
                PhoneNumber = DefaultValues.detailsDto.PhoneNumber,
                City = DefaultValues.detailsDto.City,
            };

            _testUserDetailsDb.Add(user);

            var result = await _userService.GetUserDetailsById(testGuid);
            result.Should().BeEquivalentTo(DefaultValues.detailsDto);
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
