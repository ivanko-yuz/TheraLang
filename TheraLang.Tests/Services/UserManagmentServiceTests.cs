using FluentAssertions;
using Moq;
using System;
using System.Linq;
using System.Threading.Tasks;
using TheraLang.DAL.Entities;
using TheraLang.Tests.Mocks;
using Xunit;

namespace TheraLang.Tests.Services
{
    public class UserManagmentServiceTests: UserManagerServiceSetups
    { 
        public UserManagmentServiceTests(): base()
        {
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
    }
}
