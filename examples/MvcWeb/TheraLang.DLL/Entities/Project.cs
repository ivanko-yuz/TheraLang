using System;
using System.Collections.Generic;

namespace TheraLangWeb.TheraLang.DLL.Entities
{
    public class Project
    {
        public int Id { get; set; }

        public string Name { get; set; }
        
        public ProjectStatus StatusId { get; set;  }

        public string Description { get; set; }

        public string Details { get; set; }

        public DateTime ProjectStart { get; set; }

        public DateTime ProjectEnd { get; set; }

        public bool IsActive { get; set; }

        public virtual ProjectType Type {get; set;}

        public int TypeId { get; set; }    

        public virtual ICollection<ResourceProject> ProjectResources { get; set; }

        public virtual ICollection<ProjectParticipation> ProjectParticipations { get; set; }

        public Project()
        {
            this.ProjectResources = new List<ResourceProject>();
            this.ProjectParticipations = new List<ProjectParticipation>();
        }
    }
}
