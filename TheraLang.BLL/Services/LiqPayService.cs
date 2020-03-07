using System.Threading.Tasks;
using AutoMapper;
using TheraLang.BLL.DataTransferObjects.Donations;
using TheraLang.BLL.DataTransferObjects.LiqPay;
using TheraLang.BLL.Interfaces;
using TheraLang.BLL.LiqPay;

namespace TheraLang.BLL.Services
{
    public class LiqPayService: ILiqPayService
    {
        private readonly ILiqPayInfo _liqPayInfo;

        public LiqPayService(ILiqPayInfo liqPayInfo)
        {
            _liqPayInfo = liqPayInfo;
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

            liqPayCheckout.PublicKey = _liqPayInfo.PublicKey;
            var liqPayData = new LiqPayData(liqPayCheckout);
            var liqPaySignature = new LiqPaySignature(liqPayData,_liqPayInfo.PrivateKey);
            
            return new LiqPayCheckoutDto()
            {
                Data = liqPayData.Base64Data,
                Signature = await liqPaySignature.GetSignature()
            };
        }


    }
}