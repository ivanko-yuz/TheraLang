using System.Collections.Generic;
using MvcWeb.Db.Entities;

namespace MvcWeb.TheraLang.Entities
{
    public class Resource : BaseEntity
    {
        public virtual PiranhaUser User { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Url { get; set; }

        public string File { get; set; }

        public int CategoryId { get; set; }
        // this field if resource not contains in project.
        public int? ResourceProjectId { get; set; }

        public virtual ResourceCategory ResourceCategory { get; set; }

        public virtual ICollection<ResourceProject> ResourceProject { get; set; }
        public Resource()
        {
            this.ResourceProject = new List<ResourceProject>();
        }
    }
}
