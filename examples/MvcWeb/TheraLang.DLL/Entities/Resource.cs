using System.Collections.Generic;

namespace TheraLangWeb.TheraLang.DLL.Entities
{
    public class Resource : BaseEntity
    {
        public virtual User User { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Url { get; set; }

        public string File { get; set; }

        public int CategoryId { get; set; }

        public virtual ResourceCategory ResourceCategory { get; set; }

        public virtual ICollection<ResourceProject> ResourceToProjects { get; set; }
        public Resource()
        {
            this.ResourceToProjects = new List<ResourceProject>();
        }
    }
}
