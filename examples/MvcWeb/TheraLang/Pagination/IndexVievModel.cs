using MvcWeb.Db.Entities;
using MvcWeb.TheraLang.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWeb.TheraLang.Pagination
{
    public class IndexVievModel
    {
        public IEnumerable<Project> Projects { get; set; }
        public PageVievModel PageViewModel { get; set; }
    }
}
