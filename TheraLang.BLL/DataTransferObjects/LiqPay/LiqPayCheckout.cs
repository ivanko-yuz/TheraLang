using Common.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace TheraLang.BLL.DataTransferObjects.LiqPay
{
    public class LiqPayCheckout
    {
        [JsonProperty("public_key")]
        public string PublicKey { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("action")]
        [JsonConverter(typeof(StringEnumConverter))]
        public LiqPayAction Action { get; set; }

        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        [JsonProperty("currency")]
        [JsonConverter(typeof(StringEnumConverter))]
        public LiqPayCurrency Currency { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("result_url")]
        public string ResultUrl { get; set; }

        [JsonProperty("server_url")]
        public string ServerUrl { get; set; }

        [JsonProperty("language")]
        [JsonConverter(typeof(StringEnumConverter))]
        public LiqPayLanguage Language { get; set; }
    }
}