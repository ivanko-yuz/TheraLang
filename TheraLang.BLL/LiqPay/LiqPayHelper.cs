using System;
using TheraLang.BLL.DataTransferObjects.Donations;

namespace TheraLang.BLL.LiqPay
{
    public static class LiqPayHelper
    {
        private static readonly string _privateKey;
        private static readonly string _publicKey;
        public const int ApiVersion = 3;

        public static string PublicKey => _publicKey;

        public static string PrivateKey => _privateKey;

        static LiqPayHelper()
        {
            _publicKey = Environment.GetEnvironmentVariable("LIQPAY_PUBLIC");
            _privateKey = Environment.GetEnvironmentVariable("LIQPAY_PRIVATE");
        }

        public static string GetCallbackUrl(this LiqPayCheckoutModelRequestDto requestDto,string hostUrl)
        {
            if (requestDto.ProjectId == null)
            {
                return $"{hostUrl}/society/{requestDto.SocietyId.ToString()}";
            }

            return $"{hostUrl}/project/{requestDto.ProjectId.ToString()}";
        }
    }
}