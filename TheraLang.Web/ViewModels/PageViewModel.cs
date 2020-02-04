using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheraLang.Web.ViewModels
{
    public class PageViewModel
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string Header { get; set; }
        public string MenuName { get; set; }
    }
}
