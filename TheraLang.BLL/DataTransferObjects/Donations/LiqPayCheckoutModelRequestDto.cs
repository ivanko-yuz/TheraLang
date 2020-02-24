using Common.Enums;

namespace TheraLang.BLL.DataTransferObjects.Donations
{
    public class LiqPayCheckoutModelRequestDto
    {
        public decimal DonationAmount { get; set; }
        
        public int? ProjectId { get; set; }
        
        public int? SocietyId { get; set; } // TODO : society?
        
        public LiqPayAction Action { get; set; }
        
        public LiqPayAction Currency { get; set; }

        public string Description { get; set; }
    }
}