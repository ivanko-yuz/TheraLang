using System;
using System.Collections.Generic;
using System.Text;

namespace TheraLang.DAL.Entities
{
    public class MemberFee : BaseEntity
    {
        public DateTime FeeDate { get; set; }
        public decimal FeeAmount { get; set; }
    }
}
