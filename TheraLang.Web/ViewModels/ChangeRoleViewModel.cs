using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheraLang.Web.ViewModels
{
    public class ChangeRoleViewModel
    {
        [JsonProperty("new_role")]
       public Guid NewRoleId { get; set; }
    }
}
