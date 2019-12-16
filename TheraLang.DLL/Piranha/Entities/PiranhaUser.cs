﻿using System;
using System.Collections.Generic;
using TheraLang.DLL.Entities;

namespace TheraLang.DLL.Piranha.Entities
{
    public class PiranhaUser
    {
        public PiranhaUser()
        {
            PiranhaUserClaims = new HashSet<PiranhaUserClaim>();
            PiranhaUserLogins = new HashSet<PiranhaUserLogin>();
            PiranhaUserRoles = new HashSet<PiranhaUserRole>();
            PiranhaUserTokens = new HashSet<PiranhaUserToken>();
            Resources = new HashSet<Resource>();
            ProjectParticipations = new HashSet<ProjectParticipation>();
        }

        public Guid Id { get; set; }
        public int AccessFailedCount { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public bool LockoutEnabled { get; set; }
        public DateTimeOffset? LockoutEnd { get; set; }
        public string NormalizedEmail { get; set; }
        public string NormalizedUserName { get; set; }
        public string PasswordHash { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public string SecurityStamp { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public string UserName { get; set; }

        public virtual ICollection<PiranhaUserClaim> PiranhaUserClaims { get; set; }
        public virtual ICollection<PiranhaUserLogin> PiranhaUserLogins { get; set; }
        public virtual ICollection<PiranhaUserRole> PiranhaUserRoles { get; set; }
        public virtual ICollection<PiranhaUserToken> PiranhaUserTokens { get; set; }
        public virtual ICollection<Resource> Resources { get; set; }
        public virtual ICollection<ProjectParticipation> ProjectParticipations { get; set; }
    }
}