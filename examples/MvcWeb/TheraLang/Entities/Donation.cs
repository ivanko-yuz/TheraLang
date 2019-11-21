using Newtonsoft.Json;


namespace MvcWeb.TheraLang.Entities
{
    public class Donation
    {
        public int Id { get; set; }

        [JsonProperty("product_name")]
        public int ProjectId { get; set; }

        public virtual Project Project { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("amount")]
        public decimal Amount { get; set; }
    }
}
