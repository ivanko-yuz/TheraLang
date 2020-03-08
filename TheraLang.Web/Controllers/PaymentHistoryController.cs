using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.BLL.Interfaces;
using TheraLang.Web.ViewModels;

namespace TheraLang.Web.Controllers
{
    [Route("api/paymentHistory")]
    [Authorize]
    [ApiController]
    public class PaymentHistoryController : ControllerBase
    {
        private readonly IPaymentHistoryService _paymentHistoryService;
        private readonly IAuthenticateService _authenticateService;

        public PaymentHistoryController(IPaymentHistoryService paymentHistoryService, IAuthenticateService authenticateService)
        {
            _paymentHistoryService = paymentHistoryService;
            _authenticateService = authenticateService;
        }

        [HttpPost]
        public async Task<IActionResult> AddPayment([FromBody] PaymentHistoryViewModel paymentHistoryViewModel)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<PaymentHistoryViewModel, PaymentHistoryDto>())
                .CreateMapper();
            var paymentDto = mapper.Map<PaymentHistoryViewModel, PaymentHistoryDto>(paymentHistoryViewModel);

            await _paymentHistoryService.Add(paymentDto);
            return Ok();
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            var paymentDto = await _paymentHistoryService.GetAll();
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<PaymentHistoryDto, PaymentHistoryViewModel>())
                .CreateMapper();
            var paymentViewModel = mapper.Map<IEnumerable<PaymentHistoryDto>, IEnumerable<PaymentHistoryViewModel>>(paymentDto);

            return Ok(paymentViewModel);
        }

        [HttpGet("all/{id}")]
        public async Task<IActionResult> GetAllByUserId(Guid id)
        {
            var paymentDto = await _paymentHistoryService.GetByUserId(id);
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<PaymentHistoryDto, PaymentHistoryViewModel>())
                .CreateMapper();
            var paymentViewModel = mapper.Map<IEnumerable<PaymentHistoryDto>, IEnumerable<PaymentHistoryViewModel>>(paymentDto);

            return Ok(paymentViewModel);
        }

        // GET: api/paymentHistory/id/?pageNumber=2&pageSize=10
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPageByUserId(Guid id, [FromQuery] PaginationParams pageParameters)
        {
            var paymentDto = await _paymentHistoryService.GetPageByUserId(id, pageParameters);

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<PaymentHistoryDto, PaymentHistoryViewModel>())
                .CreateMapper();
            var paymentViewModel = mapper.Map<IEnumerable<PaymentHistoryDto>, IEnumerable<PaymentHistoryViewModel>>(paymentDto);

            return Ok(paymentViewModel);
        }

        // GET: api/paymentHistory/?pageNumber=2&pageSize=10
        [HttpGet]
        public async Task<IActionResult> GetPage([FromQuery] PaginationParams pageParameters)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<PaymentHistoryDto, PaymentHistoryViewModel>())
                .CreateMapper();

            var paymentsDto = await _paymentHistoryService.GetHistoryPage(pageParameters);
            var paymentViewModel = mapper.Map<IEnumerable<PaymentHistoryDto>, IEnumerable<PaymentHistoryViewModel>>(paymentsDto);

            return Ok(paymentViewModel);
        }
    }
}
