using Castle.Core.Logging;
using Common.Configurations;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Threading;
using System.Threading.Tasks;
using TheraLang.DAL;
using TheraLang.IntegrationTests.Infrastucture.TestAuthentication;
using TheraLang.IntegrationTests.Infrastucture.TestDataSeeding;
using TheraLang.Web;

namespace TheraLang.IntegrationTests
{
    public class TestStartup : Startup
    {
        public TestStartup(IConfiguration configuration) : base(configuration)
        {
        }

        public override void Configure(IApplicationBuilder app, IHostingEnvironment env, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory)
        {
            base.Configure(app, env, loggerFactory);

            // Now seed the database
            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var seeder = serviceScope.ServiceProvider.GetService<TestDataSeeder>();
                seeder.Seed();
            }
        }

        protected override void AddAuth(IServiceCollection services)
        {
            services.AddAuthentication("Test")
                    .AddScheme<AuthenticationSchemeOptions, TestAuthHandler>(
                        "Test", options => { });
        }

        protected override void AddSendGrid(IServiceCollection services)
        {
            var _sendGridMock = new Mock<ISendGridClient>();
            _sendGridMock.SetupAllProperties();
            var response = new Response(System.Net.HttpStatusCode.OK, null, null);
            _sendGridMock.Setup(x => x.SendEmailAsync(It.IsAny<SendGridMessage>(), CancellationToken.None)).Returns(Task.FromResult(response));
            services.AddTransient<ISendGridClient>(provider => _sendGridMock.Object);
        }

        protected override void ConfigureDatabase(IServiceCollection services)
        {
            services.AddDbContext<IttmmDbContext>(options =>
            {
                options.UseInMemoryDatabase("InMemoryDbForTesting");
            });

            // Register the database seeder
            services.AddTransient<TestDataSeeder>();
        }
    }
}
