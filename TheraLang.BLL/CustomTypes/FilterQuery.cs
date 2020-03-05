using System;
using System.Collections.Generic;
using System.Text;
using TheraLang.BLL.DataTransferObjects;

namespace TheraLang.BLL.CustomTypes
{
    public class FilterQuery
    {
        public string Search { get; set; }
        public bool MyProjects { get; set; }
        public bool SortByDateAsc { get; set; }
        public bool SortByDateDesc { get; set; }
        public bool SortByDaysLeft { get; set; }
        public AuthUser User { get; set; }


    }
}
