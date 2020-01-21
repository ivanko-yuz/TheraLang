using Newtonsoft.Json;


namespace TheraLang.DAL.Models
{
    public class LiqPayCheckout
    {
        [JsonProperty("public_key")]
        public string PublicKey { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("result_url")]
        public string ResultUrl { get; set; }

        [JsonProperty("server_url")]
        public string ServerUrl { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }


    }
}
