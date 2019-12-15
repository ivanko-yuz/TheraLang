using System.Collections.Generic;

namespace TheraLang.DLL.Entities
{
    public class ProjectType : BaseEntity
    {
        public string TypeName { get; set; }

        public ICollection<Project> Projects { get; set; }

        public ProjectType()
        {
            Projects = new List<Project>();
        }
    }
}