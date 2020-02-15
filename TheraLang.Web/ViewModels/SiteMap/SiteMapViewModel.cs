using System.Collections.Generic;
using Newtonsoft.Json;

namespace TheraLang.Web.ViewModels.SiteMap
{
    public class SiteMapViewModel
    {
        public int Id { get; set; }
        
        public string MenuTitle { get; set; }
        
        public string Route { get; set; }

        public IEnumerable<SiteMapViewModel> SubPages { get; set; }
    }
}