using System;

namespace MvcWeb.TheraLang.Entities
{
    public class Project
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string Description { get; set; }
       
        public string Details { get; set; }
        
        public DateTime ProjectBegin { get; set; }
        
        public DateTime ProjectEnd { get; set; }
        public bool IsActive { get; set; }
    }
}
