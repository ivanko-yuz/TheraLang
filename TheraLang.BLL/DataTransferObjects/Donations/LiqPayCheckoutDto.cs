using System;

namespace TheraLang.BLL.DataTransferObjects.Donations
{
    public class LiqPayCheckoutDto
    {
        public int? ProjectId { get; set; }
        
        public int? SocietyId { get; set; }

        public Guid? MemberId { get; set; }

        public Guid? DonatorId { get; set; }
        
        public string Data { get; set; }

        public string Signature { get; set; }
    }
}