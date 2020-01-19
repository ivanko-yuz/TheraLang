using System;
using System.Collections.Generic;
using System.Text;
using TheraLang.DAL.Entities;

namespace TheraLang.BLL.DataTransferObjects
{
    public class ProjectDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ProjectStatusDto StatusId { get; set; }

        public string Description { get; set; }

        public string Details { get; set; }

        public DateTime ProjectStart { get; set; }

        public DateTime ProjectEnd { get; set; }

        public virtual ProjectTypeDto Type { get; set; }

        public int TypeId { get; set; }

        public decimal DonationTargetSum { get; set; }

        public virtual ICollection<ResourceProject> ProjectResources { get; set; }

        public virtual ICollection<ProjectParticipation> ProjectParticipations { get; set; }

        public virtual ICollection<Donation> Donations { get; set; }

        public ProjectDto()
        {
            this.ProjectResources = new List<ResourceProject>();
            this.ProjectParticipations = new List<ProjectParticipation>();
            this.Donations = new List<Donation>();
        }
    }
}
