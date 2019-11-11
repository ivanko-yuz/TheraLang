using System;

namespace TheraLang.Db.Entities
{
    public class PiranhaPageRevision
    {
        public Guid Id { get; set; }
        public string Data { get; set; }
        public DateTime Created { get; set; }
        public Guid PageId { get; set; }

        public virtual PiranhaPage Page { get; set; }
    }
}