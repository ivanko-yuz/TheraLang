using System;
using System.Collections.Generic;

namespace TheraLang.DAL.Piranha.Entities
{
    public sealed class PiranhaCategory
    {
        public PiranhaCategory()
        {
            PiranhaPosts = new HashSet<PiranhaPost>();
        }

        public Guid Id { get; set; }
        public Guid BlogId { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }
        public string Slug { get; set; }
        public string Title { get; set; }

        public PiranhaPage Blog { get; set; }
        public ICollection<PiranhaPost> PiranhaPosts { get; set; }
    }
}