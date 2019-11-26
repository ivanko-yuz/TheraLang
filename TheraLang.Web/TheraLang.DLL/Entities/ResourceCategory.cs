using System.Collections.Generic;

namespace TheraLang.Web.TheraLang.DLL.Entities
{
    public class ResourceCategory
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public virtual ICollection<Resource> Resources { get; set; }
        public ResourceCategory()
        {
            this.Resources = new List<Resource>();
        }
    }
}
