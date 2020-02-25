﻿using System;
using System.Threading.Tasks;
using Common.Enums;
using FluentAssertions;
using Moq;
using TheraLang.BLL.DataTransferObjects.Donations;
using TheraLang.BLL.LiqPay;
using TheraLang.BLL.Services;
using Xunit;

namespace TheraLang.Tests.Services
{
    public class LiqPayServiceTests
    {
        private readonly Mock<ILiqPayInfo> _liqPayInfo;

        public LiqPayServiceTests()
        {
            _liqPayInfo = new Mock<ILiqPayInfo>();
            _liqPayInfo.Setup(l => l.PrivateKey).Returns("testPrivateKey");
            _liqPayInfo.Setup(l => l.PublicKey).Returns("testPublicKey");
        }

        [Fact]
        public async Task GetLiqPayCheckoutModel_ValidData_ReturnsData()
        {
            var validData = new LiqPayCheckoutModelRequestDto()
            {
                Action = LiqPayAction.Pay,
                Currency = LiqPayCurrency.UAH,
                Description = "Благодійність",
                ResultUrl = "testUrl",
                ServerUrl = "testUrl/server",
                DonationAmount = 200,
                ProjectId = 1,
                UserId = new Guid("c6d93b65-022b-437e-ba65-f2d39f40b70f")
            };
            var liqPayService = new LiqPayService(_liqPayInfo.Object);

            var result = await liqPayService.GetLiqPayCheckoutModel(validData);
            
            var actualData = "eyJwdWJsaWNfa2V5IjoidGVzdFB1YmxpY0tleSIsInZlcnNpb24iOjMsImFjdGlvbiI6InBheSIsImFtb3VudCI6MjAwLjAsImN1cnJlbmN5IjoidWFoIiwiZGVzY3JpcHRpb24iOiLQkdC70LDQs9C+0LTRltC50L3RltGB0YLRjCIsInJlc3VsdF91cmwiOiJ0ZXN0VXJsIiwic2VydmVyX3VybCI6InRlc3RVcmwvc2VydmVyIiwibGFuZ3VhZ2UiOiJ1ayJ9";
            var actualSignature = "4uUz1rzjBYoPDm1/H9MNjcII+a0=";

            result.Data.Should().Be(actualData);
            result.Signature.Should().Be(actualSignature);
        }
    }
}