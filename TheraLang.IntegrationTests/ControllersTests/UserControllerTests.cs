using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TheraLang.IntegrationTests.DataBuilders;
using TheraLang.IntegrationTests.Infrastucture;
using TheraLang.IntegrationTests.Infrastucture.TestDataSeeding;
using Xunit;

namespace TheraLang.IntegrationTests.ControllersTests
{
    public class UserControllerTests : TestBase
    {
        private readonly string _baseUrl;

        public UserControllerTests(TestFixture testFixture) : base(testFixture)
        {
            _baseUrl = ControllersUrls["usersUrl"];
        }

        [Fact]
        public async Task GetMyProfile_SuccessStatusCode()
        {
            var request = $"{_baseUrl}/me";
            var response = await MemberClient.GetAsync(request);
            response.EnsureSuccessStatusCode();
        }

        [Fact]
        public async Task GetMyProfile_FailureUnauthorized()
        {
            var request = $"{_baseUrl}/me";
            var response = await UnauthorizedClient.GetAsync(request);
            Assert.Equal(HttpStatusCode.Unauthorized, response.StatusCode);
        }

        [Fact]
        public async Task GetUser_SuccessStatusCode()
        {
            var request = $"{_baseUrl}/{DefaultValues.MemberId}";
            var response = await UnauthorizedClient.GetAsync(request);
            response.EnsureSuccessStatusCode();
        }

        [Fact]
        public async Task UpdateUserDetails_SuccessStatusCode()
        {
            var request = _baseUrl;
            var user = new UsersDetailsFormDataBuilder()
                .WithDefaultFirstName()
                .WithDefaultLastName()
                .Build();
            var response = await MemberClient.PutAsync(request, user);
            response.EnsureSuccessStatusCode();
        }

        [Fact]
        public async Task UpdateUserDetails_FailureUnauthorized()
        {
            var request = _baseUrl;
            var user = new UsersDetailsFormDataBuilder()
                .WithDefaultFirstName()
                .WithDefaultLastName()
                .Build();
            var response = await UnauthorizedClient.PutAsync(request, user);
            Assert.Equal(HttpStatusCode.Unauthorized, response.StatusCode);
        }

        [Fact]
        public async Task GetAllUsers_SuccessStatusCode()
        {
            var request = _baseUrl;
            var response = await AdminClient.GetAsync(request);
            response.EnsureSuccessStatusCode();
        }

        [Fact]
        public async Task GetAllUsers_FailureUnauthorized()
        {
            var request = _baseUrl;
            var response = await UnauthorizedClient.GetAsync(request);
            Assert.Equal(HttpStatusCode.Unauthorized, response.StatusCode);
        }
        [Fact]
        public async Task GetAllUsers_FailNotAdmin()
        {
            var request = _baseUrl;
            var response = await MemberClient.GetAsync(request);
            Assert.Equal(HttpStatusCode.Forbidden, response.StatusCode);
        }

        [Fact]
        public async Task GetAdminUserView_FailureUnauthorized()
        {
            var request = $"{_baseUrl}/admin/{DefaultValues.MemberId}";
            var response = await UnauthorizedClient.GetAsync(request);
            Assert.Equal(HttpStatusCode.Unauthorized, response.StatusCode);
        }

        [Fact]
        public async Task GetAdminUserView_FailNotAdmin()
        {
            var request = $"{_baseUrl}/admin/{DefaultValues.MemberId}";
            var response = await MemberClient.GetAsync(request);
            Assert.Equal(HttpStatusCode.Forbidden, response.StatusCode);
        }

        [Fact]
        public async Task GetAdminUserView_SuccessStatusCode()
        {
            var request = $"{_baseUrl}/admin/{DefaultValues.MemberId}";
            var response = await AdminClient.GetAsync(request);
            response.EnsureSuccessStatusCode();
        }

        [Fact]
        public async Task GetRoles_SuccessStatusCode()
        {
            var request = $"{_baseUrl}/roles";
            var response = await AdminClient.GetAsync(request);
            response.EnsureSuccessStatusCode();
        }

        [Fact]
        public async Task GetRoles_FailureUnauthorized()
        {
            var request = $"{_baseUrl}/roles";
            var response = await UnauthorizedClient.GetAsync(request);
            Assert.Equal(HttpStatusCode.Unauthorized, response.StatusCode);
        }

        [Fact]
        public async Task GetRoles_FailNotAdmin()
        {
            var request = $"{_baseUrl}/roles";
            var response = await MemberClient.GetAsync(request);
            Assert.Equal(HttpStatusCode.Forbidden, response.StatusCode);
        }

        [Fact]
        public async Task GetUserRole_SuccessStatusCode()
        {
            var request = $"{_baseUrl}/{DefaultValues.MemberId}/role";
            var response = await AdminClient.GetAsync(request);
            response.EnsureSuccessStatusCode();
        }

        [Fact]
        public async Task GetUserRole_FailureUnauthorized()
        {
            var request = $"{_baseUrl}/{DefaultValues.MemberId}/role";
            var response = await UnauthorizedClient.GetAsync(request);
            Assert.Equal(HttpStatusCode.Unauthorized, response.StatusCode);
        }

        [Fact]
        public async Task GetUserRole_FailNotAdmin()
        {
            var request = $"{_baseUrl}/{DefaultValues.MemberId}/role";
            var response = await MemberClient.GetAsync(request);
            Assert.Equal(HttpStatusCode.Forbidden, response.StatusCode);
        }
    }
}
