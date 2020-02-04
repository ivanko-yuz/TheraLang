using System.Collections.Generic;

namespace TheraLang.BLL.DataTransferObjects
{
    public class SiteMapDto
    {
        public int Id { get; set; }
        
        public string MenuName { get; set; }
        
        public string Route { get; set; }
        
        public string Header { get; set; }
        
        public int? ParentPageId { get; set; }
        
        public bool Changed { get; set; }
        
        public virtual IEnumerable<SiteMapDto> SubPages { get; set; }
    }
}