﻿using System;

namespace TheraLang.DAL.Piranha.Entities
{
    public class PiranhaSiteType
    {
        public string Id { get; set; }
        public string Body { get; set; }
        public string ClrType { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }
    }
}