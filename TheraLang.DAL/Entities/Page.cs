using System.Collections.Generic;

namespace TheraLang.DAL.Entities
{
    public class Page : BaseEntity
    {
        public string Content { get; set; }
        public string Header { get; set; }
        public string MenuName { get; set; }
        public int? ParentPageId { get; set; }
        public string Route { get; set; }
        public virtual Page ParentPage { get; set; }
        public virtual ICollection<Page> SubPages { get; set; }
    }
}