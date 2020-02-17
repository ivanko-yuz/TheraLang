using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheraLang.Web.ViewModels
{
    public class MemberFeeViewModel
    {
        public int Id { get; set; }
        public DateTime FeeDate { get; set; }
        public decimal FeeAmount { get; set; }
    }
}
