using System;
using Newtonsoft.Json;

namespace TheraLang.Web.ViewModels
{
    public class ChangeRoleViewModel
    {
        [JsonProperty("new_role")]
        public Guid NewRoleId { get; set; }
    }
}