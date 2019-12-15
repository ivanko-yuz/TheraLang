using System;

namespace TheraLang.DLL.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public Guid CreatedById { get; set; }

        public Guid? UpdatedById { get; set; }   

        public DateTime CreatedDateUtc { get; set; }

        public DateTime? UpdatedDateUtc { get; set; }
    }
}
