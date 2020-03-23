using Microsoft.Extensions.PlatformAbstractions;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using TheraLang.IntegrationTests.Infrastucture.TestAuthentication;
using Xunit;

namespace TheraLang.IntegrationTests
{
    public class NewsControllerTests : IClassFixture<TestFixture>
    {
        private TestFixture _testFixture;
        private HttpClient _defaultClient;

        public NewsControllerTests(TestFixture testFixture)
        {
            _testFixture = testFixture;
            _defaultClient = testFixture.CreateClient(TestClaimsProvider.Unauthorized());
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
            var request = "/api/news/all";

            // Act
            var response = await _defaultClient.GetAsync(request);

            // Assert
            response.EnsureSuccessStatusCode();
        }

        [Fact]
        public async Task GetById_SuccessStatusCode()
        {
            // Arrange
            var request = "/api/news/1";

            // Act
            var response = await _defaultClient.GetAsync(request);

            // Assert
            response.EnsureSuccessStatusCode();
        }

        [Fact]
        public async Task Post_SuccessStatusCode()
        {
            // Arrange
            var adminClient = _testFixture.CreateClient(TestClaimsProvider.WithAdminClaims());
            var news = CreateNewsFormData();

            // Act
            var response = await adminClient.PostAsync("api/news", news);

            // Assert
            response.EnsureSuccessStatusCode();
        }

        [Fact]
        public async Task Post_FailureUnauthorized()
        {
            // Arrange
            var news = CreateNewsFormData();

            // Act
            var response = await _defaultClient.PostAsync("api/news", news);

            // Assert
            Assert.Equal(HttpStatusCode.Unauthorized, response.StatusCode);
        }
    }
}
