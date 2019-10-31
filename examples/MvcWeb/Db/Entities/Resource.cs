using System.Collections.Generic;

namespace MvcWeb.Db.Entities
{
    public class Resource : BaseEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }
        
        public string Description { get; set; }
        
        public string URL { get; set; }

        public string File { get; set; }

        public int CategoryId { get; set; }

        public virtual ResourceCategory ResourceCategory { get; set; }

        public virtual ICollection<ResourceProject> ResourceProject { get; set; }
        public Resource()
        {
            this.ResourceProject = new List<ResourceProject>();
        }
    }
}
