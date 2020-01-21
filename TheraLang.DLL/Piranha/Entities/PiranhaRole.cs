using System;
using System.Collections.Generic;

namespace TheraLang.DLL.Piranha.Entities
{
    public sealed class PiranhaRole
    {
        public PiranhaRole()
        {
            PiranhaRoleClaims = new HashSet<PiranhaRoleClaim>();
            PiranhaUserRoles = new HashSet<PiranhaUserRole>();
        }

        public Guid Id { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string Name { get; set; }
        public string NormalizedName { get; set; }

        public ICollection<PiranhaRoleClaim> PiranhaRoleClaims { get; set; }
        public ICollection<PiranhaUserRole> PiranhaUserRoles { get; set; }
    }
}