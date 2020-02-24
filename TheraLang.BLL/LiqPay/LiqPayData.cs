using System;
using System.Text;
using Newtonsoft.Json;
using TheraLang.BLL.DataTransferObjects.LiqPay;
using TheraLang.DAL.Entities;

namespace TheraLang.BLL.LiqPay
{
    public class LiqPayData
    {
        private readonly string _publicKey;
        
        private string _jsonData;
        private string _base64Data;
        private LiqPayCheckout _checkoutData;
        private LiqPayCommission _liqPayCommission;
        private Donation _donationDto;

        private LiqPayData()
        {
            _publicKey = LiqPayHelper.PublicKey;
        }
        
        public LiqPayData(LiqPayCheckout checkoutData) : this()
        {
            _checkoutData = checkoutData;
            _checkoutData.PublicKey = _publicKey;
            _checkoutData.Version = LiqPayHelper.ApiVersion;
        }

        public LiqPayData(string base64Data): this()
        {
            _base64Data = base64Data;
            _jsonData = Encoding.UTF8.GetString(Convert.FromBase64String(_base64Data));
        }

        public string JsonData => _jsonData ??= JsonConvert.SerializeObject(_checkoutData);

        public string Base64Data => _base64Data ??= Convert.ToBase64String(Encoding.UTF8.GetBytes(JsonData));

        public LiqPayCheckout LiqPayCheckout => _checkoutData ??= JsonConvert.DeserializeObject<LiqPayCheckout>(_jsonData);

        public LiqPayCommission Commission => _liqPayCommission ??= JsonConvert.DeserializeObject<LiqPayCommission>(_jsonData);

        public Donation Donation => _donationDto ??= JsonConvert.DeserializeObject<Donation>(_jsonData);
    }
}