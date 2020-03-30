using System.Threading.Tasks;
using TheraLang.IntegrationTests.DataBuilders;
using TheraLang.IntegrationTests.Infrastucture;
using Xunit;

namespace TheraLang.IntegrationTests.ControllersTests
{
    public class AccountControllerTests : TestBase
    {
        private readonly string _baseUrl;

        public AccountControllerTests(TestFixture testFixture) : base(testFixture)
        {
            _baseUrl = ControllersUrls["accountUrl"];
        }

        [Fact]
        public async Task Register_SuccessStatusCode()
        {
            var registerRequest = new UsersFormDataBuilder()
              .WithDefaultFirstName()
              .WithDefaultLastName()
              .WithDefaultPassword()
              .WithDefaultEmail()
              .WithDefaultConfirmPassword()
              .Build();
            var request = $"{_baseUrl}/registration";
            var response = await UnauthorizedClient.PostAsync(request, registerRequest);
            response.EnsureSuccessStatusCode();
        }

        [Fact]
        public async Task SignIn_SuccessStatusCode()
        {
            var loginRequest = new UserJsonDataBuilder()
               .WithDefaultEmail()
               .WithDefaultPassword()
               .Build();
            var request = $"{_baseUrl}/login";
            var response = await UnauthorizedClient.PostAsync(request, loginRequest);
            response.EnsureSuccessStatusCode();
        }

        [Fact]
        public async Task ConfirmEmail_SuccessStatusCode()
        {
            var user = new UserJsonDataBuilder()
              .WithDefaultEmail()
              .WithDefailtConfNum()
              .Build();
            var request = $"{_baseUrl}/confirmation";
            var response = await UnauthorizedClient.PostAsync(request, user);
            response.EnsureSuccessStatusCode();
        }

        [Fact]
        public async Task ConfirmUser_SuccessStatusCode()
        {
            var user = new UserJsonDataBuilder()
            .WithDefaultEmail()
            .WithDefaultPassword()
            .WithDefaultConfirmPassword()
            .WithDefailtConfNum()
            .Build();
            var request = $"{_baseUrl}/password/reset";
            var response = await UnauthorizedClient.PostAsync(request, user);
            response.EnsureSuccessStatusCode();
        }
    }
}
