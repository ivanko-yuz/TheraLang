using System.Collections.Generic;

namespace TheraLang.DAL.Entities
{
    public class ResourceCategory
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public virtual ICollection<Resource> Resources { get; set; }
    }
}