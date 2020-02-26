using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheraLang.Web.ViewModels.UsersViewModels
{
    public class ConfirmUserViewModel
    {
        [JsonProperty("confirmation_number")]
        public int ConfirmationNumber { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
    }
}
