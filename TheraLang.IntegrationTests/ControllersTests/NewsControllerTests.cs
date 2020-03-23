using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using TheraLang.IntegrationTests.Infrastucture.TestAuthentication;
using Xunit;

namespace TheraLang.IntegrationTests
{
    public class NewsControllerTests : IClassFixture<TestFixture>
    {
        private HttpClient _client;

        public NewsControllerTests(TestFixture fixture)
        {
            _client = fixture.CreateClient(TestClaimsProvider.WithAdminClaims());
        }

        [Fact]
        public async Task GetAll_SuccessStatusCode()
        {
            // Arrange
            var request = "/api/news/all";

            // Act
            var response = await _client.GetAsync(request);

            // Assert
            response.EnsureSuccessStatusCode();
        }

        [Fact]
        public async Task GetById_SuccessStatusCode()
        {
            // Arrange
            var request = "/api/news/1";

            // Act
            var response = await _client.GetAsync(request);

            // Assert
            response.EnsureSuccessStatusCode();
        }

        [Fact]
        public async Task Post_SuccessStatusCode()
        {
            // Arrange
            MultipartFormDataContent formDataContent = new MultipartFormDataContent();
            formDataContent.Add(new StringContent("Hello World!"), name: "Title");
            formDataContent.Add(new StringContent("Hello World!"), name: "Text");
            StreamContent file1 = new StreamContent(File.OpenRead(@"C:\Users\AndreyLakusta\Downloads\4_main.jpg"));
            file1.Headers.ContentType = new MediaTypeHeaderValue("image/jpg");
            file1.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data");
            file1.Headers.ContentDisposition.Name = "MainImage";
            file1.Headers.ContentDisposition.FileName = "4_main.jpg";
            formDataContent.Add(file1);

            // Act
            var response = await _client.PostAsync("api/news", formDataContent);

            // Assert
            response.EnsureSuccessStatusCode();
        }
    }
}
