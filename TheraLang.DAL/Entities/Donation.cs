using System;
using Common.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace TheraLang.DAL.Entities
{
    public class Donation
    {
        public Guid Id { get; set; }

        public int? ProjectId { get; set; }

        public int? SocietyId { get; set; }

        [JsonProperty("status")]
        public LiqPayStatus Status { get; set; }

        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        [JsonProperty("currency")]
        [JsonConverter(typeof(StringEnumConverter))]
        public LiqPayCurrency Currency { get; set; }

        [JsonProperty("payment_id")]
        public uint PaymentId { get; set; }

        [JsonProperty("liqpay_order_id")]
        public string LiqpayOrderId { get; set; }
        
        [JsonConverter(typeof(StringEnumConverter))]
        public LiqPayAction Action { get; set; }
        
        public DateTime TimeStamp { get; set; }

        public virtual Project Project { get; set; }
        
        public virtual Society Society { get; set; }
    }
}