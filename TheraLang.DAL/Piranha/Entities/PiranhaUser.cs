using System;
using System.Collections.Generic;
using TheraLang.DAL.Entities;

namespace TheraLang.DAL.Piranha.Entities
{
    public sealed class PiranhaUser
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

        public ICollection<PiranhaUserClaim> PiranhaUserClaims { get; set; }
        public ICollection<PiranhaUserLogin> PiranhaUserLogins { get; set; }
        public ICollection<PiranhaUserRole> PiranhaUserRoles { get; set; }
        public ICollection<PiranhaUserToken> PiranhaUserTokens { get; set; }
        public ICollection<Resource> Resources { get; set; }
        public ICollection<ProjectParticipation> ProjectParticipations { get; set; }
    }
}