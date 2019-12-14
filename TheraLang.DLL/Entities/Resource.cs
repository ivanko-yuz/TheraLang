using System.Collections.Generic;
using TheraLang.DLL.Piranha.Entities;

namespace TheraLang.DLL.Entities
{
    public class Resource : BaseEntity
    {
        public virtual PiranhaUser PiranhaUser { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Url { get; set; }

        public string File { get; set; }

        public int CategoryId { get; set; }

        public virtual ResourceCategory ResourceCategory { get; set; }

        public virtual ICollection<ResourceProject> ResourceProjects { get; set; }
        public Resource()
        {
            this.ResourceProjects = new List<ResourceProject>();
        }
    }
}
