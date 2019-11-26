using System.Collections.Generic;

namespace TheraLang.Web.TheraLang.DLL.Entities
{
    public class ProjectType
    {   
        public int Id { get; set; }
        
        public string TypeName { get; set; }

        public ICollection<Project> Projects { get; set; } 

        public ProjectType()
        {
            Projects = new List<Project>();
        }
    }
}
