using System;
using Common.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace TheraLang.Web.ViewModels.Donations
{
    public class DonationViewModel
    {
        public int Id { get; set; }

        public int? ProjectId { get; set; }

        public int? SocietyId { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public LiqPayStatus Status { get; set; }

        public decimal Amount { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public LiqPayCurrency Currency { get; set; }

        public int PaymentId { get; set; }

        public Guid LiqpayOrderId { get; set; }
    }
}