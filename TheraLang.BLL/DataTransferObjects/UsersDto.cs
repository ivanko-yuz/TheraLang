using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TheraLang.BLL.DataTransferObjects
{
    public class UsersDto
    {
        [JsonProperty("id")]
        public Guid UserDetailsId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ShortInformation { get; set; }
        public string ImageURl { get; set; }
        public string RoleName { get; set; }
    }
}
