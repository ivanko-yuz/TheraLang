using Newtonsoft.Json;

namespace TheraLang.DLL.Models
{
    class LiqPayCommissionModel
    {
        [JsonProperty("receiver_commission")]
        public decimal ReceiverCommission { get; set; }
    }
}
