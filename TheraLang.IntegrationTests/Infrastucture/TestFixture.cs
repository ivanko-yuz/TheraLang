using Common.Configurations;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.PlatformAbstractions;
using System;
using System.IO;
using System.Net.Http;
using TheraLang.IntegrationTests.Infrastucture.TestAuthentication;

namespace TheraLang.IntegrationTests
{
    public class TestFixture : IDisposable
    {
        private TestServer _server;
        private readonly string _applicationPath;

        public TestFixture()
        {
            var integrationTestsPath = PlatformServices.Default.Application.ApplicationBasePath;
            _applicationPath = Path.GetFullPath(Path.Combine(integrationTestsPath, "../../../../TheraLang.Web"));
        }

        public HttpClient CreateClient(TestClaimsProvider claimsProvider)
        {
            var builder = WebHost.CreateDefaultBuilder()
                .ConfigureServices(services =>
                {
                    services.AddSingleton<TestClaimsProvider>(_ => claimsProvider);
                })
                .UseStartup<TestStartup>()
                .UseContentRoot(_applicationPath)
                .UseEnvironment("Development");

            _server = new TestServer(builder);
            return _server.CreateClient();
        }

        public void Dispose()
        {
            _server.Dispose();
        }
    }
}