using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace TheraLang.Web.ViewModels
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
