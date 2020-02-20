using System;

namespace TheraLang.Web.ViewModels
{
    public class MemberFeeViewModel
    {
        public int Id { get; set; }
        public DateTime FeeDate { get; set; }
        public decimal FeeAmount { get; set; }
    }
}