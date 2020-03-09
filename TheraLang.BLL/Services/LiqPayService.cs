using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.Options;
using TheraLang.BLL.DataTransferObjects.Donations;
using TheraLang.BLL.DataTransferObjects.LiqPay;
using TheraLang.BLL.Interfaces;
using TheraLang.BLL.LiqPay;

namespace TheraLang.BLL.Services
{
    public class LiqPayService: ILiqPayService
    {
        private readonly LiqPayKeys _liqPayKeys;

        public LiqPayService(IOptions<LiqPayKeys> liqPayKeysOptions)
        {
            _liqPayKeys = liqPayKeysOptions.Value;
        }

        public async Task<LiqPayCheckoutDto> GetLiqPayCheckoutModel(
            LiqPayCheckoutModelRequestDto liqPayCheckoutModelRequest)
        {
            var mapper = new MapperConfiguration(mapOpts =>
            {
                mapOpts.CreateMap<LiqPayCheckoutModelRequestDto, LiqPayCheckout>()
                    .ForMember(c => c.Amount, opts => opts.MapFrom(dto => dto.DonationAmount));
            }).CreateMapper();
            
            var liqPayCheckout = mapper.Map<LiqPayCheckout>(liqPayCheckoutModelRequest);

            liqPayCheckout.PublicKey = _liqPayKeys.PublicKey;
            var liqPayData = new LiqPayData(liqPayCheckout);
            var liqPaySignature = new LiqPaySignature(liqPayData, _liqPayKeys.PrivateKey);
            
            return new LiqPayCheckoutDto()
            {
                Data = liqPayData.Base64Data,
                Signature = await liqPaySignature.GetSignature()
            };
        }


    }
}