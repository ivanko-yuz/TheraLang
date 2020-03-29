using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using TheraLang.IntegrationTests.DataBuilders;
using TheraLang.IntegrationTests.Infrastucture;
using TheraLang.Web.ViewModels.NewsViewModels;
using Xunit;

namespace TheraLang.IntegrationTests
{
    public class NewsControllerTests : TestBase
    {
        private readonly string _baseUrl;
        private const int _newsId = 1;

        public NewsControllerTests(TestFixture testFixture) : base(testFixture)
        {
            _baseUrl = ControllersUrls["newsUrl"];
        }

        [Fact]
        public async Task GetAll_SuccessStatusCode()
        {
            // Arrange
            var request = $"{_baseUrl}/all";

            // Act
            var response = await UnauthorizedClient.GetAsync(request);

            // Assert
            response.EnsureSuccessStatusCode();
        }

        [Fact]
        public async Task GetPage_SuccessStatusCode_RightPageSize()
        {
            // Arrange
            var pageSize = 2;
            var pageNumber = 1;
            var request = $"{_baseUrl}?pageSize={pageSize}&pageNumber={pageNumber}";

            // Act
            var response = await UnauthorizedClient.GetAsync(request);
            var result = await response.Content.ReadAsAsync<List<NewsPreviewViewModel>>();

            // Assert
            response.EnsureSuccessStatusCode();
            Assert.Equal(result.Count, pageSize);
        }

        [Fact]
        public async Task GetById_SuccessStatusCode()
        {
            // Arrange
            var request = $"{_baseUrl}/{_newsId}";

            // Act
            var response = await UnauthorizedClient.GetAsync(request);

            // Assert
            response.EnsureSuccessStatusCode();
        }

        [Fact]
        public async Task Post_SuccessStatusCode()
        {
            // Arrange
            var news = new NewsFormDataBuilder()
                .WithDefaultTitle()
                .WithDefaultText()
                .WithDefaultImage("MainImage")
                .Build();
            var request = _baseUrl;

            // Act
            var response = await AdminClient.PostAsync(request, news);

            // Assert
            response.EnsureSuccessStatusCode();
        }

        [Fact]
        public async Task Post_FailureUnauthorized()
        {
            // Arrange
            var news = new NewsFormDataBuilder()
                .WithDefaultTitle()
                .WithDefaultText()
                .WithDefaultImage("MainImage")
                .Build();
            var request = _baseUrl;

            // Act
            var response = await UnauthorizedClient.PostAsync(request, news);

            // Assert
            Assert.Equal(HttpStatusCode.Unauthorized, response.StatusCode);
        }

        [Fact]
        public async Task Edit_SuccessStatusCode()
        {
            // Arrange
            var request = $"{ _baseUrl}/{_newsId}";
            var news = new NewsFormDataBuilder()
                .WithDefaultTitle()
                .WithDefaultText()
                .WithDefaultImage("NewMainImage")
                .Build();

            // Act
            var response = await AdminClient.PutAsync(request, news);

            // Assert
            response.EnsureSuccessStatusCode();
        }

        [Fact]
        public async Task Edit_FailureUnauthorized()
        {
            // Arrange
            var request = $"{ _baseUrl}/{_newsId}";
            var news = new NewsFormDataBuilder()
                .WithDefaultTitle()
                .WithDefaultText()
                .WithDefaultImage("NewMainImage")
                .Build();

            // Act
            var response = await UnauthorizedClient.PutAsync(request, news);

            // Assert
            Assert.Equal(HttpStatusCode.Unauthorized, response.StatusCode);
        }

        [Fact]
        public async Task Like_SuccessStatusCode()
        {
            // Arrange
            var request = $"{ _baseUrl}/like/{_newsId}";

            // Act
            var response = await AdminClient.PutAsync(request, null);

            // Assert
            response.EnsureSuccessStatusCode();
        }

        [Fact]
        public async Task Like_FailureUnauthorized()
        {
            // Arrange
            var request = $"{ _baseUrl}/like/{_newsId}";

            // Act
            var response = await UnauthorizedClient.PutAsync(request, null);

            // Assert
            Assert.Equal(HttpStatusCode.Unauthorized, response.StatusCode);
        }

        [Fact]
        public async Task Remove_FailureUnauthorized()
        {
            // Arrange
            var request = $"{_baseUrl}/{_newsId}";

            // Act
            var response = await UnauthorizedClient.DeleteAsync(request);

            // Assert
            Assert.Equal(HttpStatusCode.Unauthorized, response.StatusCode);
        }

        [Fact]
        public async Task Remove_SuccessStatusCode()
        {
            // Arrange
            var request = $"{_baseUrl}/{_newsId}";

            // Act
            var response = await AdminClient.DeleteAsync(request);

            // Assert
            response.EnsureSuccessStatusCode();
        }
    }
}
