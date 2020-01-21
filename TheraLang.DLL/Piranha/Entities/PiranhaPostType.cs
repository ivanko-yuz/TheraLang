using System;
using System.Collections.Generic;

namespace TheraLang.DLL.Piranha.Entities
{
    public sealed class PiranhaPostType
    {
        public PiranhaPostType()
        {
            PiranhaPosts = new HashSet<PiranhaPost>();
        }

        public string Id { get; set; }
        public string Body { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }
        public string ClrType { get; set; }

        public ICollection<PiranhaPost> PiranhaPosts { get; set; }
    }
}