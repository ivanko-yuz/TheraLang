using System.Collections.Generic;

namespace TheraLang.Web.ViewModels.SiteMap
{
    public class SiteMapViewModel
    {
        public int Id { get; set; }
        
        public string MenuTitle { get; set; }
        
        public string Route { get; set; }

        public int? ParentId { get; set; }

        public IEnumerable<SiteMapViewModel> SubPages { get; set; }
    }
}