using Common.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace TheraLang.Web.ViewModels.Donations
{
    public class LiqPayCheckoutModelRequest
    {
        public decimal DonationAmount { get; set; }
        
        public int? ProjectId { get; set; }
        
        public int? SocietyId { get; set; }
        
        [JsonConverter(typeof(StringEnumConverter))]
        public LiqPayAction Action { get; set; }
        
        [JsonConverter(typeof(StringEnumConverter))]
        public LiqPayCurrency Currency { get; set; }
        
        public string Description { get; set; }
    }
}