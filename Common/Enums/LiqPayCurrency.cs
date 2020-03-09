using System.Runtime.Serialization;

namespace Common.Enums
{
    public enum LiqPayCurrency
    {
        [EnumMember(Value = "uah")]
        UAH,
        [EnumMember(Value = "usd")]
        USD,
        [EnumMember(Value = "eur")]
        EUR
    }
}