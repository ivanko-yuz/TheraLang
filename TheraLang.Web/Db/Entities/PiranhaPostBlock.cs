using System;

namespace TheraLang.Web.Db.Entities
{
    public class PiranhaPostBlock
    {
        public Guid Id { get; set; }
        public Guid BlockId { get; set; }
        public Guid PostId { get; set; }
        public int SortOrder { get; set; }
        public Guid? ParentId { get; set; }

        public virtual PiranhaBlock Block { get; set; }
        public virtual PiranhaPost Post { get; set; }
    }
}