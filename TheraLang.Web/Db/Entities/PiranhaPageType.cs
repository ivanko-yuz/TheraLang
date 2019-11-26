using System;
using System.Collections.Generic;

namespace TheraLang.Web.Db.Entities
{
    public class PiranhaPageType
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

        public virtual ICollection<PiranhaPage> PiranhaPages { get; set; }
    }
}