using MvcWeb.TheraLang.Entities;
using System.Collections.Generic;

namespace MvcWeb.TheraLang.Pagination
{
    public class IndexVievModel
    {
        public IEnumerable<Project> Projects { get; set; }
        public PageVievModel PageViewModel { get; set; }
    }
}
