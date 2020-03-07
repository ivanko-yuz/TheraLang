using System;
using Common.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace TheraLang.Web.ViewModels.Donations
{
    public class DonationViewModel
    {
        public Guid Id { get; set; }

        public int? ProjectId { get; set; }

        public int? SocietyId { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public LiqPayStatus Status { get; set; }

        public decimal Amount { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public LiqPayCurrency Currency { get; set; }

        public uint PaymentId { get; set; }

        public string LiqpayOrderId { get; set; }
                
        public DateTime TimeStamp { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public LiqPayAction Action { get; set; }
        
        public Guid? DonatorId { get; set; }
    }
}