using System;

namespace TheraLang.BLL.LiqPay
{
    public class LiqPayInfo: ILiqPayInfo
    {
        public string PrivateKey { get; }
        public string PublicKey { get; }

        public LiqPayInfo()
        {
            PrivateKey = Environment.GetEnvironmentVariable("LIQPAY_PRIVATE");
            PublicKey = Environment.GetEnvironmentVariable("LIQPAY_PUBLIC");
        }
    }
}