using System.Collections.Generic;

namespace MvcWeb.TheraLang.Entities
{
    public class Project
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public string Name { get; set; }

        public virtual ICollection<ResourceToProject> ResourceProjects { get; set; }

        public virtual ICollection<ProjectParticipation> ProjectParticipations { get; set; }

        public Project()
        {
            this.ResourceProjects = new List<ResourceToProject>();
            this.ProjectParticipations = new List<ProjectParticipation>();
        }
    }
}
