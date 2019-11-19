using System;

namespace MvcWeb.TheraLang.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public int CreatedById { get; set; }

        public int? UpdatedById { get; set; }   

        public DateTime CreatedDateUtc { get; set; }

        public DateTime? UpdatedDateUtc { get; set; }
    }
}
