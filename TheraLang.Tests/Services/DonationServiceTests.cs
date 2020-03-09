using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Common.Enums;
using Common.Exceptions;
using FluentAssertions;
using Microsoft.Extensions.Options;
using Moq;
using TheraLang.BLL.DataTransferObjects.Donations;
using TheraLang.BLL.LiqPay;
using TheraLang.BLL.Services;
using TheraLang.DAL.Entities;
using TheraLang.DAL.Repository;
using TheraLang.DAL.UnitOfWork;
using Xunit;

namespace TheraLang.Tests.Services
{
    public class DonationServiceTests
    {
        private readonly Mock<IUnitOfWork> _unitOfWorkMock;
        private readonly DonationService _donationService;
        private readonly IOptions<LiqPayKeys> _liqPayKeysOptions;
        private readonly List<Donation> _testDb;
        private readonly LiqPayCheckoutDto _validCheckout;

        public DonationServiceTests()
        {
            _testDb = GetTestData().ToList();
            _validCheckout = new LiqPayCheckoutDto()
            {
                Data = "eyJhY3Rpb24iOiJwYXkiLCJwYXltZW50X2lkIjoxMjUzMTU2NzE2LCJzdGF0dXMiOiJzdWNjZXNzIiwidmVyc2lvbiI6MywidHlwZSI6ImJ1eSIsInBheXR5cGUiOiJjYXJkIiwicHVibGljX2tleSI6InNhbmRib3hfaTQyODU5OTk4OTE0IiwiYWNxX2lkIjo0MTQ5NjMsIm9yZGVyX2lkIjoiSElVQjY1QlQxNTgyNTU1MTQyMTYyMDY1IiwibGlxcGF5X29yZGVyX2lkIjoiMEpYTDZVU1ExNTgyNTU1MTUwMjgyNjM2IiwiZGVzY3JpcHRpb24iOiJibGFnb2RpeW5pc3QiLCJzZW5kZXJfY2FyZF9tYXNrMiI6IjQyNDI0Mio0MiIsInNlbmRlcl9jYXJkX2JhbmsiOiJUZXN0Iiwic2VuZGVyX2NhcmRfdHlwZSI6InZpc2EiLCJzZW5kZXJfY2FyZF9jb3VudHJ5Ijo4MDQsImlwIjoiMTk1LjE2MC4yMzIuMjQ4IiwiYW1vdW50IjoxMDAuMCwiY3VycmVuY3kiOiJVU0QiLCJzZW5kZXJfY29tbWlzc2lvbiI6MC4wLCJyZWNlaXZlcl9jb21taXNzaW9uIjoyLjc1LCJhZ2VudF9jb21taXNzaW9uIjowLjAsImFtb3VudF9kZWJpdCI6MjQ1MC45OCwiYW1vdW50X2NyZWRpdCI6MjQ1MC45OCwiY29tbWlzc2lvbl9kZWJpdCI6MC4wLCJjb21taXNzaW9uX2NyZWRpdCI6NjcuNCwiY3VycmVuY3lfZGViaXQiOiJVQUgiLCJjdXJyZW5jeV9jcmVkaXQiOiJVQUgiLCJzZW5kZXJfYm9udXMiOjAuMCwiYW1vdW50X2JvbnVzIjowLjAsIm1waV9lY2kiOiI3IiwiaXNfM2RzIjpmYWxzZSwibGFuZ3VhZ2UiOiJ1ayIsImNyZWF0ZV9kYXRlIjoxNTgyNTU1MTUwMjg0LCJlbmRfZGF0ZSI6MTU4MjU1NTE1MDg3MSwidHJhbnNhY3Rpb25faWQiOjEyNTMxNTY3MTZ9",
                Signature = "unholN06qwKFFl/LB3tc1qegq4E="
            };
            
            _liqPayKeysOptions = Options.Create(new LiqPayKeys()
            {
                PrivateKey = "testPrivateKey",
                PublicKey = "testPublicKey"
            });

            var repoMock = new Mock<IRepository<Donation>>();
            repoMock.Setup(r => r.Get(It.IsAny<Expression<Func<Donation, bool>>>()))
                .ReturnsAsync((Expression<Func<Donation, bool>> predicate) => _testDb
                    .AsQueryable()
                    .Where(predicate)
                    .FirstOrDefault());
            repoMock.Setup(r => r.Add(It.IsAny<Donation>()))
                .Callback((Donation donation) =>
                {
                    donation.Id = new Guid();
                    _testDb.Add(donation);
                });
            
            _unitOfWorkMock = new Mock<IUnitOfWork>();
            _unitOfWorkMock.Setup(u => u.Repository<Donation>()).Returns(repoMock.Object);
            _unitOfWorkMock.Setup(u => u.SaveChangesAsync());

            _donationService = new DonationService(_unitOfWorkMock.Object, _liqPayKeysOptions);
        }

        [Fact]
        public async Task GetDonation_ShouldReturnDonation()
        {
            var testGuid = new Guid("507f77df-fd1c-48c5-9900-f7ace8c250f7");

            var actual = new DonationDto()
            {
                Id = new Guid("507f77df-fd1c-48c5-9900-f7ace8c250f7"),
                Amount = 300m,
                Currency = LiqPayCurrency.UAH,
                LiqpayOrderId = "testLiqPayOrderId1"
            };

            var result = await _donationService.GetDonation(testGuid);
            
            result.Should().BeEquivalentTo(actual);
        }

        [Fact]
        public async Task AddDonation_InvalidSignature()
        {
            var liqPayCheckout = new LiqPayCheckoutDto()
            {
                Data = "eyJwdWJsaWNfa2V5IjoidGVzdFB1YmxpY0tleSIsInZlcnNpb24iOjMsImFjdGlvbiI6InBheSIsImFtb3VudCI6MjAwLjAsImN1cnJlbmN5IjoidWFoIiwiZGVzY3JpcHRpb24iOiLQkdC70LDQs9C+0LTRltC50L3RltGB0YLRjCIsInJlc3VsdF91cmwiOiJ0ZXN0VXJsIiwic2VydmVyX3VybCI6InRlc3RVcmwvc2VydmVyIiwibGFuZ3VhZ2UiOiJ1ayJ9",
                Signature = "defNotAValidSignature",
                ProjectId = 1
            };

            Func<Task> act = async () => await _donationService.AddDonation(liqPayCheckout);

            await act.Should().ThrowAsync<InvalidArgumentException>();
        }

        [Fact]
        public async Task AddDonation_ShouldCallSaveChanges()
        {
            await _donationService.AddDonation(_validCheckout);
            
            _unitOfWorkMock.Verify(u => u.SaveChangesAsync(),Times.Once);
        }

        [Fact]
        public async Task AddDonation_ShouldCalculateCorrectAmountWithCommission()
        {
            const decimal actualAmount = 100.0m;
            const decimal actualCommission = 2.75m;
            const decimal actualDonationAmount = actualAmount - actualCommission;

            var newDonationId = await _donationService.AddDonation(_validCheckout);

            var resultDonation = _testDb.FirstOrDefault(d => d.Id == newDonationId);

            resultDonation.Should().NotBeNull();
            resultDonation?.Amount.Should().BePositive().And.Be(actualDonationAmount);
        }

        private IEnumerable<Donation> GetTestData()
        {
            return new List<Donation>()
            {
                new Donation()
                {
                    Id = new Guid("507f77df-fd1c-48c5-9900-f7ace8c250f7"),
                    Amount = 300m,
                    Currency = LiqPayCurrency.UAH,
                    LiqpayOrderId = "testLiqPayOrderId1"
                },
                new Donation()
                {
                    Id = new Guid("f12213c7-dd55-4ae4-89cb-e88683200728"),
                    Amount = 200m,
                    Currency = LiqPayCurrency.USD,
                    LiqpayOrderId = "testLiqPayOrderId2"
                },
                new Donation()
                {
                    Id = new Guid("950efa7f-934a-49ea-aa3a-b8b717fcdd79"),
                    Amount = 100m,
                    Currency = LiqPayCurrency.USD,
                    LiqpayOrderId = "testLiqPayOrderId3"
                },

            };
        }
    }
}