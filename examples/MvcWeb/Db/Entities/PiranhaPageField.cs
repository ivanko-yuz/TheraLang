using System;

namespace TheraLangWeb.Db.Entities
{
    public class PiranhaPageField
    {
        public Guid Id { get; set; }
        public string ClrType { get; set; }
        public string FieldId { get; set; }
        public Guid PageId { get; set; }
        public string RegionId { get; set; }
        public int SortOrder { get; set; }
        public string Value { get; set; }

        public virtual PiranhaPage Page { get; set; }
    }
}