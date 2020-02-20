using System;

namespace TheraLang.DAL.Entities
{
    public class MemberFee : BaseEntity
    {
        public DateTime FeeDate { get; set; }
        public decimal FeeAmount { get; set; }
    }
}