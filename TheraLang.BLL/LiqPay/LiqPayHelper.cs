using System;
using System.Linq;
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
        
        public static string ConvertToQueryString<T>(this T obj)
        {
            return string.Join("&", obj.GetType()
                .GetProperties()
                .Where(p => p.GetValue(obj) != null)
                .Select(p => $"{Uri.EscapeDataString(p.Name)}={Uri.EscapeDataString(p.GetValue(obj).ToString())}"));
        }
    }
}