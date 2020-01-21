using Newtonsoft.Json;


namespace TheraLang.DAL.Entities
{
    public class Donation
    {
        public int Id { get; set; }

        public int? ProjectId { get; set; }

        public virtual Project Project { get; set; }
        
        public int? SocietyId { get; set;}

        public virtual Society Society { get; set; }

        public string DonationId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }      

        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("payment_id")]
        public int PaymentId { get; set; }

        [JsonProperty("liqpay_order_id")]
        public string LiqpayOrderId { get; set; }
    }
}
