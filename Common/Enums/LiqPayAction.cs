using System.Runtime.Serialization;

namespace Common.Enums
{
    public enum LiqPayAction
    {
        [EnumMember(Value = "pay")]
        Pay,
        [EnumMember(Value = "paydonate")]
        PayDonate,
        [EnumMember(Value = "regular")]
        Regular
    }
}