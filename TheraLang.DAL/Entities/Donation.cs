using Newtonsoft.Json;

namespace TheraLang.DAL.Entities
{
    public class Donation
    {
        public int Id { get; set; }

        public int? ProjectId { get; set; }

        public virtual Project Project { get; set; }

        public int? SocietyId { get; set; }

        public virtual Society Society { get; set; }

        public string DonationId { get; set; }
        
        public string Status { get; set; }
        
        public decimal Amount { get; set; }
        
        public string Currency { get; set; }
        
        public int PaymentId { get; set; }
        
        public string LiqpayOrderId { get; set; }
    }
}