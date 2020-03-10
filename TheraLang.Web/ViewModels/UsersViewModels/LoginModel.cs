using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace TheraLang.Web.ViewModels.UsersViewModels
{
    public class LoginModel
    {
        [Required]
        [JsonProperty("email")]
        public string Email { get; set; }

        [Required]
        [JsonProperty("password")]
        public string Password { get; set; }
    }
}