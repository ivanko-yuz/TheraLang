using System;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using AutoMapper;
using Common.Exceptions;
using TheraLang.BLL.DataTransferObjects.Donations;
using TheraLang.BLL.DataTransferObjects.LiqPay;
using TheraLang.BLL.Interfaces;
using TheraLang.BLL.LiqPay;

namespace TheraLang.BLL.Services
{
    public class LiqPayService: ILiqPayService
    {
        public async Task<LiqPayCheckoutDto> GetLiqPayCheckoutModelAsync(
            LiqPayCheckoutModelRequestDto liqPayCheckoutModelRequest, string returnUrl)
        {
            _ = returnUrl ?? throw new InvalidArgumentException(nameof(returnUrl), "cannot be null");

            var mapper = new MapperConfiguration(mapOpts =>
            {
                mapOpts.CreateMap<LiqPayCheckoutModelRequestDto, LiqPayCheckout>()
                    .ForMember(c => c.Amount,
                        opts =>
                            opts.MapFrom(dto => dto.DonationAmount))
                    .ForMember(c => c.ResultUrl,
                        opts =>
                            opts.MapFrom(dto => returnUrl))
                    .ForMember(c => c.ServerUrl,
                        opts =>
                            opts.MapFrom(dto => liqPayCheckoutModelRequest.GetCallbackUrl(returnUrl)));
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