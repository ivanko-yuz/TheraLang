using System;
using System.Collections.Generic;

namespace TheraLang.DAL.Piranha.Entities
{
    public sealed class PiranhaPageType
    {
        public PiranhaPageType()
        {
            PiranhaPages = new HashSet<PiranhaPage>();
        }

        public string Id { get; set; }
        public string Body { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }
        public string ClrType { get; set; }

        public ICollection<PiranhaPage> PiranhaPages { get; set; }
    }
}