using System;

namespace TheraLang.DLL.Piranha.Entities
{
    public class PiranhaUserToken
    {
        public Guid UserId { get; set; }
        public string LoginProvider { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

        public virtual PiranhaUser User { get; set; }
    }
}