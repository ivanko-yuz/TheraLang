using System;

namespace TheraLang.DAL.Piranha.Entities
{
    public class PiranhaUserClaim
    {
        public int Id { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }
        public Guid UserId { get; set; }

        public virtual PiranhaUser User { get; set; }
    }
}