using System.Collections.Generic;

namespace MvcWeb.TheraLang.Entities
{
    public class Project
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public string Name { get; set; }
        
        public ProjectStatus StatusId { get; set;  }

        public virtual ICollection<ResourceProject> ProjectResources { get; set; }

        public virtual ICollection<ProjectParticipation> ProjectParticipations { get; set; }

        public virtual ICollection<Donation> Donations { get; set; }

        public Project()
        {
            this.ProjectResources = new List<ResourceProject>();
            this.ProjectParticipations = new List<ProjectParticipation>();
            this.Donations = new List<Donation>();
        }
    }
}
