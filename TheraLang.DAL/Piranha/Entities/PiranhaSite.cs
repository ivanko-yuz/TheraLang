﻿using System;
using System.Collections.Generic;

namespace TheraLang.DAL.Piranha.Entities
{
    public sealed class PiranhaSite
    {
        public PiranhaSite()
        {
            PiranhaAliases = new HashSet<PiranhaAlias>();
            PiranhaPages = new HashSet<PiranhaPage>();
            PiranhaSiteFields = new HashSet<PiranhaSiteField>();
        }

        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public string Description { get; set; }
        public string Hostnames { get; set; }
        public string InternalId { get; set; }
        public bool IsDefault { get; set; }
        public DateTime LastModified { get; set; }
        public string Title { get; set; }
        public string SiteTypeId { get; set; }
        public DateTime? ContentLastModified { get; set; }
        public string Culture { get; set; }

        public ICollection<PiranhaAlias> PiranhaAliases { get; set; }
        public ICollection<PiranhaPage> PiranhaPages { get; set; }
        public ICollection<PiranhaSiteField> PiranhaSiteFields { get; set; }
    }
}