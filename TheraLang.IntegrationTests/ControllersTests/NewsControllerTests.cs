using Microsoft.Extensions.PlatformAbstractions;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using TheraLang.IntegrationTests.Infrastucture;
using TheraLang.IntegrationTests.Infrastucture.TestAuthentication;
using TheraLang.Web.ViewModels.NewsViewModels;
using Xunit;

namespace TheraLang.IntegrationTests
{
    public class NewsControllerTests : TestBase
    {
        private const string _baseUrl = "api/news";

        public NewsControllerTests(TestFixture testFixture) : base(testFixture)
        {
        }

        private MultipartFormDataContent CreateNewsFormData()
        {
            MultipartFormDataContent formDataContent = new MultipartFormDataContent();
            
            formDataContent.Add(new StringContent("Hello World!"), name: "Title");
            formDataContent.Add(new StringContent("Hello World!"), name: "Text");
            
            var filePath = Path.GetFullPath(Path.Combine(PlatformServices.Default.Application.ApplicationBasePath,
                "../../../../TheraLang.Web/ClientApp/src/assets/img/uttmm.png"));
            StreamContent file1 = new StreamContent(File.OpenRead(filePath));
            
            file1.Headers.ContentType = new MediaTypeHeaderValue("image/jpg");
            file1.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data");
            file1.Headers.ContentDisposition.Name = "MainImage";
            file1.Headers.ContentDisposition.FileName = "uttmm.png";
            formDataContent.Add(file1);

            return formDataContent;
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

            // Assert
            response.EnsureSuccessStatusCode();
            var result = await response.Content.ReadAsAsync<List<NewsPreviewViewModel>>();
            Assert.Equal(result.Count, pageSize);
        }

        [Fact]
        public async Task GetById_SuccessStatusCode()
        {
            // Arrange
            int newsId = 1;
            var request = $"{_baseUrl}/{newsId}";

            // Act
            var response = await UnauthorizedClient.GetAsync(request);

            // Assert
            response.EnsureSuccessStatusCode();
        }

        [Fact]
        public async Task Post_SuccessStatusCode()
        {
            // Arrange
            var news = CreateNewsFormData();
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
            var news = CreateNewsFormData();
            var request = _baseUrl;

            // Act
            var response = await UnauthorizedClient.PostAsync(request, news);

            // Assert
            Assert.Equal(HttpStatusCode.Unauthorized, response.StatusCode);
        }

        [Fact]
        public async Task Remove_FailureUnauthorized()
        {
            // Arrange
            int newsId = 1;
            var request = $"{_baseUrl}/{newsId}";

            // Act
            var response = await UnauthorizedClient.DeleteAsync(request);

            // Assert
            Assert.Equal(HttpStatusCode.Unauthorized, response.StatusCode);
        }

        [Fact]
        public async Task Remove_SuccessStatusCode()
        {
            // Arrange
            int newsId = 1;
            var request = $"{_baseUrl}/{newsId}";

            // Act
            var response = await AdminClient.DeleteAsync(request);

            // Assert
            response.EnsureSuccessStatusCode();
        }
    }
}
