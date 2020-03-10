using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace TheraLang.Web.ViewModels.UsersViewModels
{
    public class ConfirmPasswordChangingViewModel
    {
        [JsonProperty("confirmation_number")]
        public string ConfirmationNumber { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("password")]
        public string Password { get; set; }
        [Compare("Password")]
        [JsonProperty("confirm_password")]
        public string ConfirmPassword { get; set; }
    }
}
