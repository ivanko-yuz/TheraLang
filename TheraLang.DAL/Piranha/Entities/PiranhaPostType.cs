﻿using System;
using System.Collections.Generic;

namespace TheraLang.DAL.Piranha.Entities
{
    public class PiranhaPostType
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

        public virtual ICollection<PiranhaPost> PiranhaPosts { get; set; }
    }
}