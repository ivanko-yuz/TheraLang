
using Common.Enums;
using Common.Exceptions;
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
using TheraLang.Tests.DataBuilders;
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

        private Guid _fakeUserGuid = new Guid("2960ECE9-49DA-431E-B5B2-9E9251261488");
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

            _paymentHistory = new PaymentHistoryService(_unitOfWorkMock.Object, _userManagementService.Object);
        }

        [Fact]
        public async Task GetPaymentHistoryByUserId_NotFoundException()

        {
            Func<Task> result = async () => await _paymentHistory.GetByUserId(_fakeUserGuid);
            await result.Should().ThrowAsync<NotFoundException>();
        }

        public async Task GetPagePaymentHistoryByUserId_NotFoundException()

        {
            Func<Task> result = async () => await _paymentHistory.GetPageByUserId(_fakeUserGuid, DefaultValues.PaginationParams);
            await result.Should().ThrowAsync<NotFoundException>();
        }

        public async Task AddPaymentHistory_ShouldCallSaveChanges()
        {
           // await _paymentHistory.Add()
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
    
