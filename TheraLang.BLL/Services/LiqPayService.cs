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
        public async Task<LiqPayCheckoutDto> GetLiqPayCheckoutModelAsync(
            LiqPayCheckoutModelRequestDto liqPayCheckoutModelRequest)
        {
            var mapper = new MapperConfiguration(mapOpts =>
            {
                mapOpts.CreateMap<LiqPayCheckoutModelRequestDto, LiqPayCheckout>()
                    .ForMember(c => c.Amount, opts => opts.MapFrom(dto => dto.DonationAmount));
            }).CreateMapper();

            var liqPayCheckout = mapper.Map<LiqPayCheckout>(liqPayCheckoutModelRequest);
            var liqPayData = new LiqPayData(liqPayCheckout);
            var liqPaySignature = new LiqPaySignature(liqPayData);
            
            return new LiqPayCheckoutDto()
            {
                Data = liqPayData.Base64Data,
                Signature = await liqPaySignature.GetSignature()
            };
        }


    }
}