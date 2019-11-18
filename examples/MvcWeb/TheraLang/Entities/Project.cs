using System.Collections.Generic;

namespace MvcWeb.TheraLang.Entities
{
    public class Project
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public string Name { get; set; }
        
        public ProjectStatus StatusId { get; set;  }

        public virtual ICollection<ResourceProject> ResourceProjects { get; set; }

        public virtual ICollection<ProjectParticipation> ProjectParticipations { get; set; }

        public Project()
        {
            this.ResourceProjects = new List<ResourceProject>();
            this.ProjectParticipations = new List<ProjectParticipation>();
        }
    }
}
