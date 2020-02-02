using System.Collections.Generic;

namespace TheraLang.DAL.Entities
{
    public class Page : BaseEntity
    {
        public string Content { get; set; }
        public string Title { get; set; }
        public string MenuName { get; set; }
        public int ParentPageId { get; set; }
        
        public virtual Page ParentPage { get; set; }
        public virtual ICollection<Page> SubPages { get; set; }
    }
}