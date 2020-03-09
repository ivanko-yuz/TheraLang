using System.Runtime.Serialization;

namespace Common.Enums
{
    public enum PaymentDescription
    {
        [EnumMember(Value = "MonthlyFee")]
        MonthlyFee = 0,
        [EnumMember(Value = "TopUp")]
        TopUp = 1
    }
}
