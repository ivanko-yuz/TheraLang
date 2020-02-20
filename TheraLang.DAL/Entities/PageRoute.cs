using System.Collections.Generic;

namespace TheraLang.DAL.Entities
{
    public class PageRoute
    {
        public int Id { get; set; }

        public string Route { get; set; }

        public ICollection<Page> Pages { get; set; }
    }
}