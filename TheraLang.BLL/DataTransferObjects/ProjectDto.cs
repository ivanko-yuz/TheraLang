using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
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

        public int TypeId { get; set; }
        public string ImgUrl { get; set; }
        public IFormFile ImgFile { get; set; }

        public decimal DonationTargetSum { get; set; }

        public virtual IEnumerable<ResourceProject> ProjectResources { get; set; }

        public virtual IEnumerable<ProjectParticipation> ProjectParticipations { get; set; }

        public virtual IEnumerable<Donation> Donations { get; set; }
    }
}
