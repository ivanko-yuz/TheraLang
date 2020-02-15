using System.Collections.Generic;
using TheraLang.DAL.Enums;

namespace TheraLang.DAL.Entities
{
    public class Page : BaseEntity
    {
        public string Content { get; set; }
        
        public string Header { get; set; }
        
        public string MenuTitle { get; set; }
        
        public int? ParentPageId { get; set; }

        public int SortOrder { get; set; }

        public Language Language { get; set; }

        public int RouteId { get; set; }

        public virtual Page ParentPage { get; set; }
        
        public virtual ICollection<Page> SubPages { get; set; }

        public virtual PageRoute PageRoute { get; set; }
    }
}