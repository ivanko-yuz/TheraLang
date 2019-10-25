using System;

namespace ConsoleApp
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