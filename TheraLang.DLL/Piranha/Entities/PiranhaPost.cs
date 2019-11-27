using System;
using System.Collections.Generic;

namespace TheraLang.DLL.Piranha.Entities
{
    public class PiranhaPost
    {
        public PiranhaPost()
        {
            PiranhaPostBlocks = new HashSet<PiranhaPostBlock>();
            PiranhaPostFields = new HashSet<PiranhaPostField>();
            PiranhaPostRevisions = new HashSet<PiranhaPostRevision>();
            PiranhaPostTags = new HashSet<PiranhaPostTag>();
        }

        public Guid Id { get; set; }
        public Guid BlogId { get; set; }
        public Guid CategoryId { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }
        public string PostTypeId { get; set; }
        public DateTime? Published { get; set; }
        public int RedirectType { get; set; }
        public string RedirectUrl { get; set; }
        public string Route { get; set; }
        public string Slug { get; set; }
        public string Title { get; set; }

        public virtual PiranhaPage Blog { get; set; }
        public virtual PiranhaCategory Category { get; set; }
        public virtual PiranhaPostType PostType { get; set; }
        public virtual ICollection<PiranhaPostBlock> PiranhaPostBlocks { get; set; }
        public virtual ICollection<PiranhaPostField> PiranhaPostFields { get; set; }
        public virtual ICollection<PiranhaPostRevision> PiranhaPostRevisions { get; set; }
        public virtual ICollection<PiranhaPostTag> PiranhaPostTags { get; set; }
    }
}