﻿using System;
using System.Collections.Generic;

namespace TheraLang.DAL.Entities
{
    public class Role
    { 

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string NormalizedName { get; set; }

    }
}