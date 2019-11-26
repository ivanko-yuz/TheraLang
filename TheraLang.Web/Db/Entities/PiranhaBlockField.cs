using System;

namespace TheraLang.Web.Db.Entities
{
    public class PiranhaBlockField
    {
        public Guid Id { get; set; }
        public Guid BlockId { get; set; }
        public string ClrType { get; set; }
        public string FieldId { get; set; }
        public int SortOrder { get; set; }
        public string Value { get; set; }

        public virtual PiranhaBlock Block { get; set; }
    }
}