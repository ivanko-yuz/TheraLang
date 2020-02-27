using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using TheraLang.DAL.Entities;

namespace TheraLang.BLL.DataTransferObjects.Projects
{
    public class ProjectPreviewDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ProjectStatus StatusId { get; set; }

        public string Description { get; set; }

        public string Details { get; set; }

        public DateTime ProjectStart { get; set; }

        public DateTime ProjectEnd { get; set; }

        public int TypeId { get; set; }
        
        public string ImgUrl { get; set; }

        public decimal DonationTargetSum { get; set; }
        
        public decimal DonationsSum { get; set; }
    }
}