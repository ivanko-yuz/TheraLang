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
using TheraLang.Tests.Mocks;
using Xunit;

namespace TheraLang.Tests.Services
{
    public class AuthenticationServiceTests
    {
        private readonly AuthenticationService _authService;
        private readonly Mock<IUnitOfWork> _unitOfWorkMock;
        private readonly RepositoryMock<User> _userRepoMock;
        private readonly RepositoryMock<Role> _roleRepoMock;

        public AuthenticationServiceTests()
        {
            _userRepoMock = new RepositoryMock<User>(GetUsersTestData().ToList());
            _roleRepoMock = new RepositoryMock<Role>(GetRolesTestData().ToList());

            _unitOfWorkMock = new Mock<IUnitOfWork>();
            _unitOfWorkMock.Setup(u => u.Repository<User>()).Returns(_userRepoMock.Repository.Object);
            _unitOfWorkMock.Setup(u => u.Repository<Role>()).Returns(_roleRepoMock.Repository.Object);
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
            var user = GetUsersTestData().Where(u => u.Id == UserDefaultValues.DefaultId).FirstOrDefault();
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

        [Fact]
        public async Task GetAuthUser_ShouldReturnAuthUser()
        {
            var result = await _authService.GetAuthUser();
            result.Should().BeEquivalentTo(UserDefaultValues.authUser);
        }

        private IEnumerable<User> GetUsersTestData()
        {
            var data = new List<User>();

            var role = new Role
            {
                Id = UserDefaultValues.DefaultRoleId,
                Name = "Admin"
            };

            var user = new User
            {
                Id = UserDefaultValues.DefaultId,
                Email = UserDefaultValues.FakeEmail,
                RoleId = DefaultValues.FakeGuid,
                Role = role
            };
            data.Add(user);
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
