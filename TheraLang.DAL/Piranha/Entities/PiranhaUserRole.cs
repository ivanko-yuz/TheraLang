﻿using System;

namespace TheraLang.DAL.Piranha.Entities
{
    public class PiranhaUserRole
    {
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }

        public virtual PiranhaRole Role { get; set; }
        public virtual PiranhaUser User { get; set; }
    }
}