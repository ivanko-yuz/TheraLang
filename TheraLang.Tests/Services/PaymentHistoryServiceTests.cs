using Common.Enums;
using Common.Exceptions;
using FluentAssertions;
using MockQueryable.Moq;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.BLL.Interfaces;
using TheraLang.BLL.Services;
using TheraLang.DAL.Entities;
using TheraLang.DAL.Repository;
using TheraLang.DAL.UnitOfWork;
using TheraLang.Tests.DataBuilders.ResourcesBuilders;
using Xunit;

namespace TheraLang.Tests.Services
{
    public class PaymentHistoryServiceTests
    {
        private readonly Mock<IUnitOfWork> _unitOfWorkMock;
        private readonly Mock<IUserManagementService> _userManagementService;
        private readonly PaymentHistoryService _paymentHistory;
        private readonly List<PaymentHistory> _dbSet;

        public PaymentHistoryServiceTests()
        {
            var repoMock = new Mock<IRepository<PaymentHistory>>();
            _dbSet = GetTestData();

            repoMock.Setup(r => r.GetAll())
                .Returns(_dbSet.AsQueryable().BuildMock().Object);
            repoMock.Setup(r => r.Add(It.IsAny<PaymentHistory>()));

            _unitOfWorkMock = new Mock<IUnitOfWork>();
            _unitOfWorkMock.Setup(u => u.Repository<PaymentHistory>()).Returns(repoMock.Object);
            _unitOfWorkMock.Setup(u => u.SaveChangesAsync()).Verifiable();

            _userManagementService = new Mock<IUserManagementService>();
            _userManagementService.Setup(u => u.GetUserById(It.IsAny<Guid>()))
                .ReturnsAsync(new UserTestBuilder()
                    .WithId(DefaultValues.UserGuid)
                    .WithDefault()
                    .WithDefaultDetails()
                    .WithDefaultRole()
                    .Build());

            _paymentHistory = new PaymentHistoryService(_unitOfWorkMock.Object, _userManagementService.Object);
        }

        [Fact]
        public async Task GetPaymentHistoryByUserId_NotFoundException()
        {
            Func<Task> result = async () => await _paymentHistory.GetByUserId(DefaultValues.FakeGuid);
            await result.Should().ThrowAsync<NotFoundException>();
        }

        [Fact]
        public async Task GetPagePaymentHistoryByUserId_NotFoundException()
        {
            Func<Task> result = async () => await _paymentHistory.GetPageByUserId(DefaultValues.FakeGuid, DefaultValues.PaginationParams);
            await result.Should().ThrowAsync<NotFoundException>();
        }

        [Fact]
        public async Task AddPaymentHistory_ShouldCallSaveChanges()
        {
            await _paymentHistory.Add(new PaymentHistoryDto()
            {
                CurrentBalance = 500,
                Date = DateTime.Now,
                Saldo = -100,
                Description = 0,
                UserId = DefaultValues.UserGuid
            });
            _unitOfWorkMock.Verify(u => u.SaveChangesAsync(), Times.Once);
        }

        private List<PaymentHistory> GetTestData()
        {

            return new List<PaymentHistory>()
            {
                new PaymentHistoryTestBuilder()
                    .WithDate(DateTime.Now.AddDays(-1))
                    .WithDescription(PaymentDescription.MonthlyFee)
                    .WithId(new Guid())
                    .WithSaldo(-100)
                    .WithCurrentBalance(500)
                    .WithGeneratedPayer(DefaultValues.UserGuid)
                    .Build(),

                 new PaymentHistoryTestBuilder()
                    .WithDate(DateTime.Now.AddDays(-2))
                    .WithDescription(PaymentDescription.MonthlyFee)
                    .WithId(new Guid())
                    .WithSaldo(-100)
                    .WithCurrentBalance(-100)
                    .WithGeneratedPayer(new Guid())
                    .Build()
            };
        }
    }
}
    
