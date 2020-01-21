using System.Collections.Generic;

namespace TheraLang.DLL.Entities
{
    public sealed class ResourceCategory
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public ICollection<Resource> Resources { get; set; }
        public ResourceCategory()
        {
            this.Resources = new List<Resource>();
        }
    }
}
