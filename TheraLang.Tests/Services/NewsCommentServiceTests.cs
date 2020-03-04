using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TheraLang.BLL.Services;
using TheraLang.DAL.Entities;
using TheraLang.DAL.Repository;
using TheraLang.DAL.UnitOfWork;
using Xunit;

namespace TheraLang.Tests.Services
{
    public class NewsCommentServiceTests
    {
        private readonly Mock<IUnitOfWork> _unitOfWorkMock;
        private readonly NewsCommentService _commentsService;
        private readonly List<NewsComment> _testDb;

        public NewsCommentServiceTests()
        {
            _testDb = GetTestData().ToList();

            var repoMock = new Mock<IRepository<NewsComment>>();
            
            repoMock.Setup(r => r.GetAll()).Returns(_testDb.AsQueryable());
            
            repoMock.Setup(r => r.Add(It.IsAny<NewsComment>()))
                .Callback((NewsComment comment) =>
                {
                    comment.Id = _testDb.Count;
                    _testDb.Add(comment);
                });

            _unitOfWorkMock = new Mock<IUnitOfWork>();
            _unitOfWorkMock.Setup(u => u.Repository<NewsComment>()).Returns(repoMock.Object);
            _unitOfWorkMock.Setup(u => u.SaveChangesAsync());

            _commentsService = new NewsCommentService(_unitOfWorkMock.Object);
        }

        [Fact]
        public async Task GetCommentsForNewsCount_ShoulReturnCommentsCount()
        {
            int newsId = 1;
            int actualCount = _testDb.Where(c => c.NewsId == newsId).Count();

            var result = await _commentsService.GetCommentsForNewsCount(newsId);

            result.Should().Be(actualCount);
        }

        //[Fact]
        //public async Task AddDonation_InvalidSignature()
        //{
        //    var liqPayCheckout = new LiqPayCheckoutDto()
        //    {
        //        Data = "eyJwdWJsaWNfa2V5IjoidGVzdFB1YmxpY0tleSIsInZlcnNpb24iOjMsImFjdGlvbiI6InBheSIsImFtb3VudCI6MjAwLjAsImN1cnJlbmN5IjoidWFoIiwiZGVzY3JpcHRpb24iOiLQkdC70LDQs9C+0LTRltC50L3RltGB0YLRjCIsInJlc3VsdF91cmwiOiJ0ZXN0VXJsIiwic2VydmVyX3VybCI6InRlc3RVcmwvc2VydmVyIiwibGFuZ3VhZ2UiOiJ1ayJ9",
        //        Signature = "defNotAValidSignature",
        //        ProjectId = 1
        //    };

        //    Func<Task> act = async () => await _commentsService.AddDonation(liqPayCheckout);

        //    await act.Should().ThrowAsync<InvalidArgumentException>();
        //}

        //[Fact]
        //public async Task AddDonation_ShouldCallSaveChanges()
        //{
        //    await _commentsService.AddDonation(_validCheckout);

        //    _unitOfWorkMock.Verify(u => u.SaveChangesAsync(), Times.Once);
        //}

        //[Fact]
        //public async Task AddDonation_ShouldCalculateCorrectAmountWithCommission()
        //{
        //    const decimal actualAmount = 100.0m;
        //    const decimal actualCommission = 2.75m;
        //    const decimal actualDonationAmount = actualAmount - actualCommission;

        //    var newDonationId = await _commentsService.AddDonation(_validCheckout);

        //    var resultDonation = _testDb.FirstOrDefault(d => d.Id == newDonationId);

        //    resultDonation.Should().NotBeNull();
        //    resultDonation?.Amount.Should().BePositive().And.Be(actualDonationAmount);
        //}

        private IEnumerable<NewsComment> GetTestData()
        {
            return new List<NewsComment>()
            {
                new NewsComment()
                {
                    Text = "Text",
                    CreatedById = new Guid(),
                    NewsId = 1
                }
            };
        }
    }
}
