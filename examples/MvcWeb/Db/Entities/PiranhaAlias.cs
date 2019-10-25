using System;

namespace ConsoleApp
{
    public class PiranhaAlias
    {
        public Guid Id { get; set; }
        public string AliasUrl { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }
        public string RedirectUrl { get; set; }
        public Guid SiteId { get; set; }
        public int Type { get; set; }

        public virtual PiranhaSite Site { get; set; }
    }
}