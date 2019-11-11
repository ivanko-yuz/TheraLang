using System;
using System.Collections.Generic;

namespace TheraLang.Db.Entities
{
    public class PiranhaTag
    {
        public PiranhaTag()
        {
            PiranhaPostTags = new HashSet<PiranhaPostTag>();
        }

        public Guid Id { get; set; }
        public Guid BlogId { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }
        public string Slug { get; set; }
        public string Title { get; set; }

        public virtual PiranhaPage Blog { get; set; }
        public virtual ICollection<PiranhaPostTag> PiranhaPostTags { get; set; }
    }
}