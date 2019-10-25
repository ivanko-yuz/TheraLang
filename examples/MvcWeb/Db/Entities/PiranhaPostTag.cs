using System;

namespace MvcWeb.Db.Entities
{
    public class PiranhaPostTag
    {
        public Guid PostId { get; set; }
        public Guid TagId { get; set; }

        public virtual PiranhaPost Post { get; set; }
        public virtual PiranhaTag Tag { get; set; }
    }
}