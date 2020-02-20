using System;
using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.DAL.Models;

namespace TheraLang.BLL
{
    public class LiqPayHelper
    {
        private static readonly string _privateKey;
        private static readonly string _publicKey;
        private const int ApiVersion = 3;

        static LiqPayHelper()
        {
            _publicKey = Environment.GetEnvironmentVariable("LIQPAY_PUBLIC");
            _privateKey = Environment.GetEnvironmentVariable("LIQPAY_PRIVATE");
        }

        public static LiqPayCheckoutDto GetLiqPayCheckoutModel(string donationAmount, int? projectId,
            HttpContext context)
        {
            var donationId = Guid.NewGuid().ToString();
            var hostName = $"{context.Request.Scheme}://{context.Request.Host}";
            var dataSource = new LiqPayCheckout()
            {
                PublicKey = _publicKey,
                Version = ApiVersion,
                Action = "pay",
                Amount = Convert.ToDecimal(donationAmount),
                Currency = "UAH",
                Description = "Благодійність",
                ResultUrl = $"{hostName}/transaction/{donationId}",
                ServerUrl = $"{hostName}/api/donations/{donationId}/{projectId}",
                Language = "uk"
            };

            var jsonString = JsonConvert.SerializeObject(dataSource);
            var data = Convert.ToBase64String(Encoding.UTF8.GetBytes(jsonString));
            var signature = GetLiqPaySignature(data);

            var checkoutModel = new LiqPayCheckoutDto()
            {
                Data = data,
                Signature = signature,
            };

            return checkoutModel;
        }

        public static string GetLiqPaySignature(string data)
        {
            return Convert.ToBase64String(SHA1.Create()
                .ComputeHash(Encoding.UTF8.GetBytes(_privateKey + data + _privateKey)));
        }
    }
}