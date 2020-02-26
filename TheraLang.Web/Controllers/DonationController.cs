using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TheraLang.BLL.DataTransferObjects.Donations;
using TheraLang.BLL.Interfaces;
using TheraLang.BLL.LiqPay;
using TheraLang.Web.ViewModels.Donations;

namespace TheraLang.Web.Controllers
{
    [Route("api/donations")]
    [ApiController]
    public class DonationController : ControllerBase
    {
        private readonly IDonationService _donationService;
        private readonly ILiqPayService _liqPayService;
        private readonly IAuthenticateService _authenticateService;

        public DonationController(IDonationService donationService, ILiqPayService liqPayService,
            IAuthenticateService authenticateService)
        {
            _donationService = donationService;
            _liqPayService = liqPayService;
            _authenticateService = authenticateService;
        }
        
        /// <summary>
        /// Generates LiqPay request data to process checkout
        /// </summary>
        /// <param name="liqPayCheckoutRequest"></param>
        /// <returns>LiqPayCheckoutModel</returns>
        [HttpGet("liqpay")]
        [AllowAnonymous]
        public async Task<IActionResult> Get([FromQuery]LiqPayCheckoutModelRequest liqPayCheckoutRequest)
        {
            var hostUrl = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host.Value}";
            var userId = (await _authenticateService.TryGetAuthUser())?.Id;

            var mapper = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<LiqPayCheckoutDto, LiqPayCheckoutViewModel>();
                    cfg.CreateMap<LiqPayCheckoutModelRequest, LiqPayCheckoutModelRequestDto>();
                })
                .CreateMapper();
            
            
            var resultQueryString = new
            {
                DonatorId = userId,
                liqPayCheckoutRequest.ProjectId,
                liqPayCheckoutRequest.SocietyId
            }.ConvertToQueryString();

            var liqPayCheckoutModelDto = mapper.Map<LiqPayCheckoutModelRequestDto>(liqPayCheckoutRequest);
            
            liqPayCheckoutModelDto.ResultUrl = hostUrl;
            liqPayCheckoutModelDto.ServerUrl = $"{hostUrl}/api/donations/checkout?{resultQueryString}";

            var liqPayCheckoutDto =
                await _liqPayService.GetLiqPayCheckoutModel(liqPayCheckoutModelDto);

            var liqPayCheckoutModel = mapper.Map<LiqPayCheckoutDto, LiqPayCheckoutViewModel>(liqPayCheckoutDto);

            return Ok(liqPayCheckoutModel);
        }

        /// <summary>
        /// Get donation by Id
        /// </summary>
        /// <param name="donationId"></param>
        /// <returns>Donation record</returns>
        [HttpGet("{donationId}")]
        [AllowAnonymous]
        public async Task<IActionResult> Get(Guid donationId)
        {
            var donationDto = await _donationService.GetDonation(donationId);

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<DonationDto, DonationViewModel>()).CreateMapper();
            var donationModel = mapper.Map<DonationDto, DonationViewModel>(donationDto);

            return Ok(donationModel);
        }

        /// <summary>
        /// API for LiqPay check in 
        /// </summary>
        /// <param name="info"></param>
        /// <param name="checkoutViewModel"></param>
        /// <returns>status code</returns>
        [HttpPost("checkout")]
        [AllowAnonymous]
        public async Task<IActionResult> PostProjectDonation([FromQuery] LiqPayCheckoutInfoViewModel info, [FromForm] LiqPayCheckoutViewModel checkoutViewModel)
        {
            var mapper = new MapperConfiguration(mapOpts =>
                mapOpts.CreateMap<LiqPayCheckoutViewModel, LiqPayCheckoutDto>()
                    .ForMember(dto => dto.ProjectId, opts => opts.MapFrom(vm => info.ProjectId))
                    .ForMember(dto => dto.SocietyId, opts => opts.MapFrom(vm => info.SocietyId))
                    .ForMember(dto => dto.DonatorId, opts => opts.MapFrom(vm => info.DonatorId))
                ).CreateMapper();
            
            var liqPayDto = mapper.Map<LiqPayCheckoutDto>(checkoutViewModel);

            await _donationService.AddDonation(liqPayDto);
            return Ok();
        }
    }
}