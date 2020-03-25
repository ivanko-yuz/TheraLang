using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.PlatformAbstractions;
using System.IO;
using System.Net.Http;
using TheraLang.IntegrationTests.Infrastucture.TestAuthentication;
using Xunit;

namespace TheraLang.IntegrationTests.Infrastucture
{
    public class TestBase : IClassFixture<TestFixture>
    {
        public HttpClient UnauthorizedClient;
        public HttpClient AdminClient;
        public HttpClient MemberClient;
        public IConfigurationSection ControllersUrls; 

        public TestBase(TestFixture testFixture)
        {
            UnauthorizedClient = testFixture.CreateClient(TestClaimsProvider.Unauthorized());
            AdminClient = testFixture.CreateClient(TestClaimsProvider.WithAdminClaims());
            MemberClient = testFixture.CreateClient(TestClaimsProvider.WithMemberClaims());
            
            var configuration = InitConfiguration();
            ControllersUrls = configuration.GetSection("ControllersUrls");
        }

        private IConfiguration InitConfiguration()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(PlatformServices.Default.Application.ApplicationBasePath,
                    "../../../"))
                .AddJsonFile("appsettings.tests.json")
                .Build();
            return config;
        }
    }
}
