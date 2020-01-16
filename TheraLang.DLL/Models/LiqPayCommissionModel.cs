using Newtonsoft.Json;

namespace TheraLang.DLL.Models
{
    public class LiqPayCommissionModel
    {
        [JsonProperty("receiver_commission")]
        public decimal ReceiverCommission { get; set; }
    }
}
