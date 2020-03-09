using Newtonsoft.Json;

namespace TheraLang.BLL.DataTransferObjects.LiqPay
{
    public class LiqPayCommission
    {
        [JsonProperty("receiver_commission")]
        public decimal ReceiverCommission { get; set; }
    }
}