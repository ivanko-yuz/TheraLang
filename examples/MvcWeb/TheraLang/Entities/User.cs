using System.Collections.Generic;

namespace MvcWeb.TheraLang.Entities
{
    public class User
    {
        public int Id { get; set; }

        public ICollection<Resource> Resources { get; set; }

        public User()
        {
            this.Resources = new List<Resource>();
        }
    }
}
