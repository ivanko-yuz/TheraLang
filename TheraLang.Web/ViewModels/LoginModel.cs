using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace TheraLang.Web.ViewModels
{ 
    public class LoginModel
    {
        [Required]
        [JsonProperty("username")]
        public string UserName { get; set; }
        [Required]
        [JsonProperty("password")]
        public string Password { get; set; }
    }
}
