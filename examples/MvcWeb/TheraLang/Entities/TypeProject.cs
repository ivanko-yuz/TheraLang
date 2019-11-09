using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWeb.TheraLang.Entities
{
    public class TypeProject
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public ICollection<Project> Projects { get; set; } 
        public TypeProject()
        {
            Projects = new List<Project>();
        }
    }
}
