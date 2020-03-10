using Newtonsoft.Json;

namespace TheraLang.Web.ViewModels.UsersViewModels
{
    public class LoginResponse
    {
        [JsonProperty("token")]
        public string Token { get; set; }
    }
}