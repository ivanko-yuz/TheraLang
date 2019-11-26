using System;
using System.Collections.Generic;

namespace TheraLang.Web.Db.Entities
{
    public class PiranhaRole
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

        public virtual ICollection<PiranhaRoleClaim> PiranhaRoleClaims { get; set; }
        public virtual ICollection<PiranhaUserRole> PiranhaUserRoles { get; set; }
    }
}