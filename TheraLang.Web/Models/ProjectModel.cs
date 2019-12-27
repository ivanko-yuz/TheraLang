using System;

namespace TheraLang.Web.Models
{
    public class ProjectModel
    {
        public int? Id { get; set; }

        public string Name { get; set; }

        public int TypeId { get; set; }

        public string Description { get; set; }

        public string Details { get; set; }

        public DateTime ProjectStart { get; set; }

        public DateTime ProjectEnd { get; set; }

        public decimal DonationTargetSum { get; set; }
    }
}
