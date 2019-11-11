using System;

namespace TheraLang.Db.Entities
{
    public class PiranhaPostField
    {
        public Guid Id { get; set; }
        public string ClrType { get; set; }
        public string FieldId { get; set; }
        public Guid PostId { get; set; }
        public string RegionId { get; set; }
        public int SortOrder { get; set; }
        public string Value { get; set; }

        public virtual PiranhaPost Post { get; set; }
    }
}