using System.Collections.Generic;

namespace TheraLang.DAL.Entities
{
    public class Resource : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Url { get; set; }
        
        public int CategoryId { get; set; }
        
        public virtual User User { get; set; }

        public virtual ResourceCategory ResourceCategory { get; set; }

        public virtual ICollection<ResourceProject> ResourceProjects { get; set; }
    }
}