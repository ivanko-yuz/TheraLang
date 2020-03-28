using Common.Configurations;
using FluentAssertions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using MockQueryable.Moq;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Claims;
using System.Security.Principal;
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
    public class AuthenticationServiceTests
    {
        private readonly AuthenticationService _authService;
        private readonly Mock<IUnitOfWork> _unitOfWorkMock;
        private readonly List<User> _testUsersDb;
        private readonly List<Role> _testRolesDb;

        public AuthenticationServiceTests()
        {
            _testUsersDb = GetUsersTestData().ToList();
            _testRolesDb = GetRolesTestData().ToList();

            var userRepoMock = new Mock<IRepository<User>>();
            var roleRepoMock = new Mock<IRepository<Role>>();
            userRepoMock.Setup(r => r.GetAll()).Returns(_testUsersDb.AsQueryable().BuildMock().Object);
            userRepoMock.Setup(r => r.Get(It.IsAny<Expression<Func<User, bool>>>()))
                 .ReturnsAsync((Expression<Func<User, bool>> predicate) => _testUsersDb
                 .AsQueryable()
                 .Where(predicate)
                 .FirstOrDefault());
            userRepoMock.Setup(r => r.Add(It.IsAny<User>()))
                .Callback((User User) =>
                {
                    _testUsersDb.Add(User);
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

            _unitOfWorkMock = new Mock<IUnitOfWork>();
            _unitOfWorkMock.Setup(u => u.Repository<User>()).Returns(userRepoMock.Object);
            _unitOfWorkMock.Setup(u => u.Repository<Role>()).Returns(roleRepoMock.Object);
            var _tokenSettings = Options.Create(new TokenManagement());
            _tokenSettings.Value.Secret = "Any String used to sign and verify JWT Tokens,  Replace this string with your own Secret";
            _tokenSettings.Value.Issuer = "Some secret";
            _tokenSettings.Value.Audience = "Some secret";
            _tokenSettings.Value.AccessExpiration = 3600;
            var _mockHttpContextAccessor = new Mock<IHttpContextAccessor>();
            var claims = new List<Claim>();
            claims.Add(new Claim("Id", UserDefaultValues.authUser.Id.ToString()));
            claims.Add(new Claim(ClaimTypes.Email, UserDefaultValues.authUser.UserEmail));
            claims.Add(new Claim(ClaimTypes.Role, UserDefaultValues.authUser.Role));
            _mockHttpContextAccessor.Setup(u => u.HttpContext.User.Claims).Returns(claims.AsEnumerable);
            _authService = new AuthenticationService(_tokenSettings, _mockHttpContextAccessor.Object);
        }

        [Fact]
        public async Task Authenticate_ShouldAutificateUser()
        {
            var role = new Role
            {
                Id = DefaultValues.FakeGuid,
                Name = "Admin"
            };
            var user = new User
            {
                Id = DefaultValues.Guid,
                Email = UserDefaultValues.FakeEmail,
                RoleId = DefaultValues.FakeGuid,
                Role = role
            };

            _testRolesDb.Add(role);
            _testUsersDb.Add(user);

            var result = await _authService.Authenticate(user);
            result.Should().BeOfType<string>();
        }

        [Fact]
        public async Task Authenticate_Exception()
        {
            var user = new User();
            Func<Task> result = async () => await _authService.Authenticate(user);
            await result.Should().ThrowAsync<NullReferenceException>();
        }

        [Fact]
        public async Task TryGetAuthUser_ShouldReturnAuthUser()
        {
            var result = await _authService.TryGetAuthUser();
            result.Should().BeEquivalentTo(UserDefaultValues.authUser);
        }

        public async Task GetAuthUser_ShouldReturnAuthUser()
        {
            var result = await _authService.GetAuthUser();
            result.Should().BeEquivalentTo(UserDefaultValues.authUser);
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

    }
}
