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
using TheraLang.Tests.DataBuilders.ResoursesBuilders;
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

            repoMock.Setup(r => r.GetAll()).Returns(_testDb.AsQueryable().BuildMock().Object);
            repoMock.Setup(r => r.Get(It.IsAny<Expression<Func<NewsComment, bool>>>()))
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

            var _authService = new Mock<IAuthenticateService>();
            //_authService.Setup(a=>a.GetAuthUserAsync()).Returns()

            _commentsService = new NewsCommentService(_unitOfWorkMock.Object);
        }

        [Fact]
        public async Task RemoveComments_NotFoundException()
        {
            Func<Task> result = async () => await _commentsService.RemoveComment(DefaultValues.FakeId);
            await result.Should().ThrowAsync<NotFoundException>();
        }

        [Fact]
        public async Task RemoveComments_ShouldCallSaveChanges()
        {
            await _commentsService.RemoveComment(DefaultValues.ExistedId);
            _unitOfWorkMock.Verify(u => u.SaveChangesAsync(), Times.Once);
        }

        [Fact]
        public async Task UpdateComments_NotFoundException()
        {
            Func<Task> result = async () => await _commentsService.UpdateComment(DefaultValues.FakeId, null);
            await result.Should().ThrowAsync<NotFoundException>();
        }

        [Fact]
        public async Task UpdateComments_ShouldCallSaveChanges()
        {
            await _commentsService.UpdateComment(DefaultValues.ExistedId, DefaultValues.CommentRequest);
            _unitOfWorkMock.Verify(u => u.SaveChangesAsync(), Times.Once);
        }

        [Fact]
        public async Task AddComment_ShouldCallSaveChanges()
        {
            await _commentsService.AddComment(DefaultValues.CommentRequest);
            _unitOfWorkMock.Verify(u => u.SaveChangesAsync(), Times.Once);
        }

        [Fact]
        public async Task GetCommentsForNewsCount_ShouldReturnCommentsCount()
        {
            int actualResult = _testDb.Where(c => c.NewsId == DefaultValues.ExistedId).Count();
            int result = await _commentsService.GetCommentsForNewsCount(DefaultValues.ExistedId);

            result.Should().Be(actualResult);
        }

        [Fact]
        public async Task GetCommentsForNews_NotFoundException()
        {
            Func<Task> result = async () => await _commentsService.GetCommentsForNews(DefaultValues.FakeId);
            await result.Should().ThrowAsync<NotFoundException>();
        }

        [Fact]
        public async Task GetCommentsForNewsPage_NotFoundException()
        {
            Func<Task> result = async () => await _commentsService
                .GetCommentsForNewsPage(DefaultValues.FakeId, DefaultValues.FakePaginationParams);
            await result.Should().ThrowAsync<NotFoundException>();
        }

        private IEnumerable<NewsComment> GetTestData()
        {
            var data = new List<NewsComment>();
            
            for (int i = 0; i < DefaultValues.ListSize; i++)
            {
                var dataBuilder = new CommentsBuilder();
                data.Add(dataBuilder
                    .WithId(i)
                    .WithAuthorId(new Guid())
                    .WithNewsId(DefaultValues.ExistedId)
                    .WithDefaultText()
                    .Build()); 
            }

            return data.AsEnumerable();
        }
    }
}
