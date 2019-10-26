using System.Collections.Generic;

namespace MvcWeb.Db.Entities
{
    public class ResourceCategory
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public virtual List<Resource> Resources { get; set; }
        public ResourceCategory()
        {
            this.Resources = new List<Resource>();
        }
    }
}
