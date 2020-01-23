using System;
using System.Collections.Generic;

namespace TheraLang.DAL.Piranha.Entities
{
    public sealed class PiranhaPost
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

        public PiranhaPage Blog { get; set; }
        public PiranhaCategory Category { get; set; }
        public PiranhaPostType PostType { get; set; }
        public ICollection<PiranhaPostBlock> PiranhaPostBlocks { get; set; }
        public ICollection<PiranhaPostField> PiranhaPostFields { get; set; }
        public ICollection<PiranhaPostRevision> PiranhaPostRevisions { get; set; }
        public ICollection<PiranhaPostTag> PiranhaPostTags { get; set; }
    }
}