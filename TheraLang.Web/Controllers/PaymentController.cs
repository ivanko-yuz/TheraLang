using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TheraLang.BLL.DataTransferObjects.Donations;
using TheraLang.BLL.Interfaces;
using TheraLang.BLL.LiqPay;
using TheraLang.Web.ViewModels.Donations;
using TheraLang.Web.ViewModels.Payment;

namespace TheraLang.Web.Controllers
{
    [Route("api/user/payment")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly ILiqPayService _liqPayService;
        private readonly IPaymentService _paymentService;

        public PaymentController(ILiqPayService liqPayService, IAuthenticateService authenticateService, IPaymentService paymentService)
        {
            _liqPayService = liqPayService;
            _paymentService = paymentService;
        }

        [HttpGet("liqpay")]
        [AllowAnonymous]
        public async Task<IActionResult> Get([FromQuery]PaymentCheckoutModelRequest paymentCheckoutRequest)
        {
            var hostUrl = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host.Value}";

            var mapper = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<LiqPayCheckoutDto, LiqPayCheckoutViewModel>();
                cfg.CreateMap<PaymentCheckoutModelRequest, LiqPayCheckoutModelRequestDto>();
            })
                .CreateMapper();


            var resultQueryString = new
            {
                paymentCheckoutRequest.MemberId
            }.ConvertToQueryString();


            var liqPayCheckoutModelDto = mapper.Map<LiqPayCheckoutModelRequestDto>(paymentCheckoutRequest);

            liqPayCheckoutModelDto.ResultUrl = $"{hostUrl}/profile/";


            liqPayCheckoutModelDto.ServerUrl = $"{hostUrl}/api/user/payment/checkout?{resultQueryString}";

            var liqPayCheckoutDto =
                await _liqPayService.GetLiqPayCheckoutModel(liqPayCheckoutModelDto);

            var liqPayCheckoutModel = mapper.Map<LiqPayCheckoutDto, LiqPayCheckoutViewModel>(liqPayCheckoutDto);

            return Ok(liqPayCheckoutModel);
        }

        [HttpPost("checkout")]
        [AllowAnonymous]
        public async Task<IActionResult> PostProjectDonation([FromQuery] PaymentCheckoutInfoViewModel info, [FromForm] LiqPayCheckoutViewModel checkoutViewModel)
        {
            var mapper = new MapperConfiguration(mapOpts => mapOpts.CreateMap<LiqPayCheckoutViewModel, LiqPayCheckoutDto>()
                                .ForMember(dto => dto.MemberId, opts => opts.MapFrom(vm => info.MemberId)))
                                        .CreateMapper();

            var liqPayDto = mapper.Map<LiqPayCheckoutDto>(checkoutViewModel);

            await _paymentService.TopUpBalance(liqPayDto);
            return Ok();
        }
    }
}
