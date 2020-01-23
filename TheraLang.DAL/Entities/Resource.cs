using System.Collections.Generic;
using TheraLang.DAL.Piranha.Entities;

namespace TheraLang.DAL.Entities
{
    public class Resource : BaseEntity
    {
        public PiranhaUser PiranhaUser { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Url { get; set; }

        public string FileName { get; set; }

        public string File { get; set; }

        public int CategoryId { get; set; }

        public ResourceCategory ResourceCategory { get; set; }

        public ICollection<ResourceProject> ResourceProjects { get; set; }
        public ICollection<ResourceAttachment> ResourceAttach { get; set; }
        public Resource()
        {
            this.ResourceAttach = new List<ResourceAttachment>();
            this.ResourceProjects = new List<ResourceProject>();
        }
    }
}
