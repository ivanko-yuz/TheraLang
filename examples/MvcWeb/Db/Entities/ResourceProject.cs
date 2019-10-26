using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWeb.Db.Entities
{
    public class ResourceProject
    {
        public int? ResourceId { get; set; }

        public virtual Resource Resource { get; set; }

        public int? ProjectId { get; set; }

        public virtual Project Project { get; set; }
    }
}
