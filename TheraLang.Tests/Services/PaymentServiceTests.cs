using FluentAssertions;
using MockQueryable.Moq;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using TheraLang.BLL.Services;
using TheraLang.DAL.Entities;
using TheraLang.DAL.Repository;
using TheraLang.DAL.UnitOfWork;
using TheraLang.Tests.DataBuilders.ResourcesBuilders;
using Xunit;

namespace TheraLang.Tests.Services
{
    public class PaymentServiceTests
    {
        private readonly Mock<IUnitOfWork> _unitOfWorkMock;
        private readonly SchedulerService _paymentService;
        private readonly List<MemberFee> _dbSetMemberFees;
        private readonly List<UserDetails> _dbSetUserDetails;
        public PaymentServiceTests()
        {
            _dbSetUserDetails = GetTestUserDetails();
            _dbSetMemberFees = GetTestMemberFees();

            var userDetailsRepoMock = new Mock<IRepository<UserDetails>>();
            var membersFeeRepoMock = new Mock<IRepository<MemberFee>>();
            var paymentHistoryRepoMock = new Mock<IRepository<PaymentHistory>>();

            userDetailsRepoMock.Setup(r => r.GetAll())
                .Returns(_dbSetUserDetails.AsQueryable().BuildMock().Object);
            userDetailsRepoMock.Setup(r => r.UpdateRange(It.IsAny<IEnumerable<UserDetails>>()));

            membersFeeRepoMock.Setup(r => r.GetAll())
                .Returns(_dbSetMemberFees.AsQueryable().BuildMock().Object);

            paymentHistoryRepoMock.Setup(r => r.AddRange(It.IsAny<IEnumerable<PaymentHistory>>()));


            _unitOfWorkMock = new Mock<IUnitOfWork>();
            _unitOfWorkMock.Setup(u => u.Repository<UserDetails>()).Returns(userDetailsRepoMock.Object);
            _unitOfWorkMock.Setup(u => u.Repository<MemberFee>()).Returns(membersFeeRepoMock.Object);
            _unitOfWorkMock.Setup(u => u.Repository<PaymentHistory>()).Returns(paymentHistoryRepoMock.Object);
            _unitOfWorkMock.Setup(u => u.SaveChangesAsync()).Verifiable();

            _paymentService = new SchedulerService(_unitOfWorkMock.Object);
        }

        [Fact]
        public void Execute_ShouldCallSaveChanges()
        {
            _paymentService.Execute();
            _unitOfWorkMock.Verify(u => u.SaveChangesAsync(), Times.Once);
        }

        [Fact]
        public void Execute_ShouldWithdrawFromBalance()
        {
            _paymentService.Execute();
            _dbSetUserDetails[0].Balance.Should().Be(-100);
            _dbSetUserDetails[1].Balance.Should().Be(-100);
        }

        private List<UserDetails> GetTestUserDetails()
        {
            return new List<UserDetails>()
            {
                new UserDetailsTestBuilder()
                .WithUserDetailsId(new Guid())
                .WithDefault()
                .WithDefaultUser()
                .Build(),

                new UserDetailsTestBuilder()
                .WithUserDetailsId(new Guid())
                .WithDefault()
                .WithDefaultUser()
                .Build(),

                new UserDetailsTestBuilder()
                .WithUserDetailsId(new Guid())
                .WithDefault()
                .WithDefaultUser()
                .WithDefaultUserAndCustomRole(new RoleTestBuilder()
                    .RoleAdmin()
                    .Build())
                .Build()
            };
        }
        private List<MemberFee> GetTestMemberFees()
        {
            return new List<MemberFee>()
            {
                new MemberFee()
                {
                    FeeDate = new DateTime(2020,2,1),
                    FeeAmount = 100
                },
                new MemberFee()
                {
                    FeeDate = new DateTime(2020,4,1),
                    FeeAmount = 150
                },
                new MemberFee()
                {
                    FeeDate = new DateTime(2020,6,1),
                    FeeAmount = 200
                },
            };
        }
    }
}
