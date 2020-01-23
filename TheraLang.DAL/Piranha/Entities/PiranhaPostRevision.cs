using System;

namespace TheraLang.DAL.Piranha.Entities
{
    public class PiranhaPostRevision
    {
        public Guid Id { get; set; }
        public string Data { get; set; }
        public DateTime Created { get; set; }
        public Guid PostId { get; set; }

        public virtual PiranhaPost Post { get; set; }
    }
}