using Common.Exceptions;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TheraLang.BLL.DataTransferObjects.CommentDtos;
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

        private int notExistedId = -10;
        private int existedId = 1;
        private int newsId = 1;

        public NewsCommentServiceTests()
        {
            _testDb = GetTestData().ToList();

            var repoMock = new Mock<IRepository<NewsComment>>();
            
            repoMock.Setup(r=>r.Get(It.IsAny<Expression<Func<NewsComment, bool>>>()))
                .ReturnsAsync((Expression<Func<NewsComment, bool>> predicate) => _testDb
                    .AsQueryable()
                    .Where(predicate)
                    .FirstOrDefault());
            repoMock.Setup(r => r.Add(It.IsAny<NewsComment>()))
                .Callback((NewsComment comment) =>
                {
                    comment.Id = _testDb.Count;
                    _testDb.Add(comment);
                });

            _unitOfWorkMock = new Mock<IUnitOfWork>();
            _unitOfWorkMock.Setup(u => u.Repository<NewsComment>()).Returns(repoMock.Object);
            _unitOfWorkMock.Setup(u => u.SaveChangesAsync()).Verifiable();

            _commentsService = new NewsCommentService(_unitOfWorkMock.Object);
        }

        [Fact]
        public async Task RemoveComments_NotFoundException()
        {
            Func<Task> result = async() => await _commentsService.RemoveComment(notExistedId);
            await result.Should().ThrowAsync<NotFoundException>();
        }

        [Fact]
        public async Task RemoveComments_ShouldCallSaveChanges()
        {
            await _commentsService.RemoveComment(existedId);
            _unitOfWorkMock.Verify(u => u.SaveChangesAsync(), Times.Once);
        }

        [Fact]
        public async Task UpdateComments_NotFoundException()
        {
            Func<Task> result = async () => await _commentsService.UpdateComment(notExistedId, null);
            await result.Should().ThrowAsync<NotFoundException>();
        }

        [Fact]
        public async Task UpdateComments_ShouldCallSaveChanges()
        {
            var comment = new CommentRequestDto() { Text = "New Text" };
            await _commentsService.UpdateComment(existedId, comment);
            _unitOfWorkMock.Verify(u => u.SaveChangesAsync(), Times.Once);
        }

        private IEnumerable<NewsComment> GetTestData()
        {
            return new List<NewsComment>()
            {
                new NewsComment()
                {
                    Id = 1,
                    Text = "Text",
                    CreatedById = new Guid(),
                    NewsId = 1
                }
            };
        }
    }
}
