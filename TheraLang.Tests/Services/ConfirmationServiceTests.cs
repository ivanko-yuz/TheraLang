using FluentAssertions;
using Moq;
using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using SendGrid.Helpers.Mail;
using TheraLang.Tests.Setups;

namespace TheraLang.Tests.Services
{
   public class ConfirmationServiceTests: ConfirmationServiceSetups
    {
        public ConfirmationServiceTests(): base()
        {
        }

        [Fact]
        public async Task SendEmail_ShouldSendEmail()
        {
            await _confirmationService.SendEmail(UserDefaultValues.DefaultConfirmNum, UserDefaultValues.DefaultEmail, UserDefaultValues.DefaultPathTo);
            _sendGridMock.Verify(x => x.SendEmailAsync(It.IsAny<SendGridMessage>(), CancellationToken.None), Times.Once);
        }

        [Fact]
        public async Task ConfirmUser_ShouldChangeRole()
        {
            await _confirmationService.ConfirmUser(UserDefaultValues.ConfirmUser);
            _unitOfWorkMock.Verify(u => u.SaveChangesAsync(), Times.Once);
        }

        [Fact]
        public async Task ConfirmUser_Exception()
        {
            Func<Task> result = async () => await _confirmationService.ConfirmUser(UserDefaultValues.FakeConfirnmation);
            await result.Should().ThrowAsync<NullReferenceException>();
        }

        [Fact]
        public async Task ConfirmPassword_ShouldChangePassword()
        {
            await _confirmationService.ConfirmPassword(UserDefaultValues.confirmPasswordChanging);
            _unitOfWorkMock.Verify(u => u.SaveChangesAsync(), Times.Once);
        }
    }
}
