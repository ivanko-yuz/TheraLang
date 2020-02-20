using Newtonsoft.Json;

namespace TheraLang.DAL.Models
{
    public class LiqPayCommissionModel
    {
        [JsonProperty("receiver_commission")]
        public decimal ReceiverCommission { get; set; }
    }
}