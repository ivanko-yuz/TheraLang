using MvcWeb.TheraLang.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWeb.TheraLang.ResourcesPagination
{
    public class IndexViewModel
    {
        public IEnumerable<Resource> Resources { get; set; }
        public PageInfo PageInfo { get; set; }
    }
}
