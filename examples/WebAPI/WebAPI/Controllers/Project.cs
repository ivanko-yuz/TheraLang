using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string description { get; set; }
        public string Type { get; set; }
    }
}
