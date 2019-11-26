using System;
using System.Collections.Generic;

namespace TheraLang.Web.Db.Entities
{
    public class PiranhaCategory
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

        public virtual PiranhaPage Blog { get; set; }
        public virtual ICollection<PiranhaPost> PiranhaPosts { get; set; }
    }
}