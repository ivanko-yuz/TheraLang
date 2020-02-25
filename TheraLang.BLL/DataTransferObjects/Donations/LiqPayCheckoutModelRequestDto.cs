using System;
using Common.Enums;

namespace TheraLang.BLL.DataTransferObjects.Donations
{
    public class LiqPayCheckoutModelRequestDto
    {
        public decimal DonationAmount { get; set; }
        
        public int? ProjectId { get; set; }
        
        public Guid? UserId { get; set; }
        
        public int? SocietyId { get; set; }
        
        public LiqPayAction Action { get; set; }
        
        public LiqPayCurrency Currency { get; set; }

        public string Description { get; set; }
        
        public string ResultUrl { get; set; }
        
        public string ServerUrl { get; set; }
    }
}