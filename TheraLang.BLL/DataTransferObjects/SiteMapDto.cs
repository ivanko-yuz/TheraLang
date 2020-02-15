using System.Collections.Generic;

namespace TheraLang.BLL.DataTransferObjects
{
    public class SiteMapDto
    {
        public int Id { get; set; }
        
        public string MenuTitle { get; set; }
        
        public string Route { get; set; }
        
        public int? SortOrder { get; set; }

        public int? ParentPageId { get; set; }

        public virtual IEnumerable<SiteMapDto> SubPages { get; set; }
    }
}