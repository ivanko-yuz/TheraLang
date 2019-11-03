using System;

namespace MvcWeb.Db.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }

        public int CreatedbyId { get; set; }

        public int? UpdatedbyId { get; set; }

        public DateTime CreatedDateUTC { get; set; }

        public DateTime? UpdatedDateUTC { get; set; }
    }
}
