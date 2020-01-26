using Newtonsoft.Json;

namespace TheraLang.Web.ViewModels
{
    public class LoginResponse
    {
        [JsonProperty("token")]
        public string Token { get; set; }
    }
}