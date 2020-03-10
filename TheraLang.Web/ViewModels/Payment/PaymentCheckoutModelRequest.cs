using Common.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace TheraLang.Web.ViewModels.Payment
{
    public class PaymentCheckoutModelRequest
    {
        public decimal DonationAmount { get; set; }

        public Guid MemberId { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public LiqPayAction Action { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public LiqPayCurrency Currency { get; set; }

        public string Description { get; set; }

        public string ResultUrl { get; set; }

    }
}
