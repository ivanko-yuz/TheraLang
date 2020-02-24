using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TheraLang.BLL.DataTransferObjects.Donations;
using TheraLang.BLL.Interfaces;
using TheraLang.Web.ViewModels.Donations;

namespace TheraLang.Web.Controllers
{
    [Route("api/donations")]
    [ApiController]
    public class DonationController : ControllerBase
    {
        private readonly IDonationService _donationService;
        private readonly ILiqPayService _liqPayService;

        public DonationController(IDonationService donationService, ILiqPayService liqPayService)
        {
            _donationService = donationService;
            _liqPayService = liqPayService;
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
            
            var mapper = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<LiqPayCheckoutDto, LiqPayCheckoutViewModel>();
                    cfg.CreateMap<LiqPayCheckoutModelRequest, LiqPayCheckoutModelRequestDto>();
                })
                .CreateMapper();

            var liqpayCheckoutModelDto = mapper.Map<LiqPayCheckoutModelRequestDto>(liqPayCheckoutRequest);

            var liqPayCheckoutDto =
                await _liqPayService.GetLiqPayCheckoutModelAsync(liqpayCheckoutModelDto, hostUrl);

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
            var donationDto = await _donationService.GetDonationAsync(donationId);

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<DonationDto, DonationViewModel>()).CreateMapper();
            var donationModel = mapper.Map<DonationDto, DonationViewModel>(donationDto);

            return Ok(donationModel);
        }

        /// <summary>
        /// API for LiqPay check in 
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="checkoutViewModel"></param>
        /// <returns>status code</returns>
        [HttpPost("project/{projectId?}")]
        [AllowAnonymous]
        public async Task<IActionResult> PostProjectDonation(int projectId, [FromForm] LiqPayCheckoutViewModel checkoutViewModel)
        {
            var mapper = new MapperConfiguration(mapOpts =>
                mapOpts.CreateMap<LiqPayCheckoutViewModel, LiqPayCheckoutDto>()
                    .ForMember(dto => dto.ProjectId,
                        opts =>
                            opts.MapFrom(vm => projectId))
            ).CreateMapper();
            
            var liqPayDto = mapper.Map<LiqPayCheckoutDto>(checkoutViewModel);

            await _donationService.AddDonationAsync(liqPayDto);
            return Ok();
        }
        
        /// <summary>
        /// API for LiqPay check in
        /// </summary>
        /// <param name="societyId"></param>
        /// <param name="checkoutViewModel"></param>
        /// <returns></returns>
        [HttpPost("society/{societyId}")]
        public async Task<IActionResult> PostSocietyDonation(int societyId, [FromForm] LiqPayCheckoutViewModel checkoutViewModel)
        {
            var mapper = new MapperConfiguration(mapOpts =>
                mapOpts.CreateMap<LiqPayCheckoutViewModel, LiqPayCheckoutDto>()
                    .ForMember(dto => dto.SocietyId,
                        opts =>
                            opts.MapFrom(vm => societyId))
            ).CreateMapper();
            var liqPayDto = mapper.Map<LiqPayCheckoutDto>(checkoutViewModel);

            await _donationService.AddDonationAsync(liqPayDto);
            return Ok();
        }
    }
}