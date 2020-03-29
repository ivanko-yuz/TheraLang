using FluentAssertions;
using MockQueryable.Moq;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using TheraLang.BLL.Services;
using TheraLang.DAL.Entities;
using TheraLang.DAL.Repository;
using TheraLang.DAL.UnitOfWork;
using TheraLang.Tests.DataBuilders.ResourcesBuilders;
using Xunit;
using Microsoft.AspNetCore.Hosting;
using Common.Configurations;
using Common.Helpers.PasswordHelper;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;
using TheraLang.Tests.Mocks;
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
