using System;

namespace TheraLang.BLL.DataTransferObjects
{
    public class MemberFeeDto
    {
        public int Id { get; set; }
        public DateTime FeeDate { get; set; }
        public decimal FeeAmount { get; set; }
    }
}