using Newtonsoft.Json;

namespace TheraLang.Web.ViewModels.UsersViewModels
{
    public class ConfirmUserViewModel
    {
        [JsonProperty("confirmation_number")]
        public string ConfirmationNumber { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
    }
}
