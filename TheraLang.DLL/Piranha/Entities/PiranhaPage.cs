using System;
using System.Collections.Generic;

namespace TheraLang.DLL.Piranha.Entities
{
    public sealed class PiranhaPage
    {
        public PiranhaPage()
        {
            InverseParent = new HashSet<PiranhaPage>();
            PiranhaCategories = new HashSet<PiranhaCategory>();
            PiranhaPageBlocks = new HashSet<PiranhaPageBlock>();
            PiranhaPageFields = new HashSet<PiranhaPageField>();
            PiranhaPageRevisions = new HashSet<PiranhaPageRevision>();
            PiranhaPosts = new HashSet<PiranhaPost>();
            PiranhaTags = new HashSet<PiranhaTag>();
        }

        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public bool IsHidden { get; set; }
        public DateTime LastModified { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }
        public string NavigationTitle { get; set; }
        public string PageTypeId { get; set; }
        public Guid? ParentId { get; set; }
        public DateTime? Published { get; set; }
        public int RedirectType { get; set; }
        public string RedirectUrl { get; set; }
        public string Route { get; set; }
        public Guid SiteId { get; set; }
        public string Slug { get; set; }
        public int SortOrder { get; set; }
        public string Title { get; set; }
        public string ContentType { get; set; }
        public Guid? OriginalPageId { get; set; }

        public PiranhaPageType PageType { get; set; }
        public PiranhaPage Parent { get; set; }
        public PiranhaSite Site { get; set; }
        public ICollection<PiranhaPage> InverseParent { get; set; }
        public ICollection<PiranhaCategory> PiranhaCategories { get; set; }
        public ICollection<PiranhaPageBlock> PiranhaPageBlocks { get; set; }
        public ICollection<PiranhaPageField> PiranhaPageFields { get; set; }
        public ICollection<PiranhaPageRevision> PiranhaPageRevisions { get; set; }
        public ICollection<PiranhaPost> PiranhaPosts { get; set; }
        public ICollection<PiranhaTag> PiranhaTags { get; set; }
    }
}