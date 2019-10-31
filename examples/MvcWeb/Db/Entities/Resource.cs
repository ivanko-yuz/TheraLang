using System;
using System.Collections.Generic;

namespace MvcWeb.Db.Entities
{
    public class Resource
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime Date { get; set; }

        public string Description { get; set; }

        public int CategoryId { get; set; }

        public virtual ResourceCategory ResourceCategory { get; set; }

        public virtual ICollection<ResourceProject> ResourceProject { get; set; }
        public Resource()
        {
            this.ResourceProject = new List<ResourceProject>();
        }
    }
}
