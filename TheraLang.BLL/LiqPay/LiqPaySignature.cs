using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TheraLang.BLL.LiqPay
{
    public class LiqPaySignature
    {
        private readonly LiqPayData _liqPayData;
        private readonly string _privateKey;

        private string _signature;

        public LiqPaySignature(LiqPayData liqPayData, string privateKey)
        {
            _liqPayData = liqPayData;
            _privateKey = privateKey;
        }
        
        public LiqPaySignature(string data, string privateKey) : this(new LiqPayData(data), privateKey)
        {}

        public async Task<bool> Validate(string otherSignature)
        {
            var signature = await GetSignature();
            return string.Equals(signature, otherSignature);
        }

        public async Task<bool> Validate(LiqPaySignature other)
        {
            return await Validate(await other.GetSignature());
        }
        
        public async Task<string> GetSignature()
        {
            return _signature ??= await Task.Run(() => Convert.ToBase64String(SHA1.Create()
                .ComputeHash(Encoding.UTF8.GetBytes($"{_privateKey}{_liqPayData.Base64Data}{_privateKey}"))));
        }
    }
}