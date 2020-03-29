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
using TheraLang.DAL.Entities;
using TheraLang.Tests.Setups;
using Xunit;

namespace TheraLang.Tests.Services
{
    public class AuthenticationServiceTests: AuthenticationServiceSetups
    {
        public AuthenticationServiceTests(): base()
        {
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
    }
}
