using FluentAssertions;
using Moq;
using System;
using System.Threading.Tasks;
using TheraLang.Tests.Setups;
using Xunit;

namespace TheraLang.Tests.Services
{
    public class UserServiceTests: UserServiceSetups
    {
        public UserServiceTests(): base()
        {
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
    }
}

