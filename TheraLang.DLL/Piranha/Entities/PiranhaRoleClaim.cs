using System;

namespace TheraLang.DLL.Piranha.Entities
{
    public class PiranhaRoleClaim
    {
        public int Id { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }
        public Guid RoleId { get; set; }

        public virtual PiranhaRole Role { get; set; }
    }
}