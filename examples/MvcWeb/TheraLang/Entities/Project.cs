using System;
﻿using System.Collections.Generic;
namespace MvcWeb.TheraLang.Entities
{
    public class Project
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Details { get; set; }

        public DateTime ProjectStart { get; set; }

        public DateTime ProjectEnd { get; set; }

        public bool IsActive { get; set; }

        public virtual ProjectType Type {get; set;}

        public int TypeId { get; set; }    

        public virtual ICollection<ResourceProject> ResourceProjects { get; set; }

        public virtual ICollection<ProjectParticipation> ProjectParticipations { get; set; }

        public Project()
        {
            this.ResourceProjects = new List<ResourceProject>();
            this.ProjectParticipations = new List<ProjectParticipation>();
        }
    }
}
