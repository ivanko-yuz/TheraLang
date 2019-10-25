using System;

namespace MvcWeb.Db.Entities
{
    public class PiranhaSiteField
    {
        public Guid Id { get; set; }
        public string ClrType { get; set; }
        public string FieldId { get; set; }
        public string RegionId { get; set; }
        public Guid SiteId { get; set; }
        public int SortOrder { get; set; }
        public string Value { get; set; }

        public virtual PiranhaSite Site { get; set; }
    }
}