using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Common.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TheraLang.BLL.CustomTypes;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.BLL.Interfaces;
using TheraLang.Web.ViewModels;

namespace TheraLang.Web.Controllers
{
    [Route("api/payments")]
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
        [Authorize]
        public async Task<IActionResult> AddPayment([FromBody] PaymentHistoryViewModel paymentHistoryViewModel)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<PaymentHistoryViewModel, PaymentHistoryDto>())
                .CreateMapper();
            var paymentDto = mapper.Map<PaymentHistoryViewModel, PaymentHistoryDto>(paymentHistoryViewModel);

            await _paymentHistoryService.Add(paymentDto);
            return Ok();
        }


        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetAll()
        {
            var paymentDto = await _paymentHistoryService.GetAll();
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<PaymentHistoryDto, PaymentHistoryViewModel>())
                .CreateMapper();
            var paymentViewModel = mapper.Map<IEnumerable<PaymentHistoryDto>, IEnumerable<PaymentHistoryViewModel>>(paymentDto);

            return Ok(paymentViewModel);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAllByUserId(Guid id)
        {
            var paymentDto = await _paymentHistoryService.GetByUserId(id);
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<PaymentHistoryDto, PaymentHistoryViewModel>())
                .CreateMapper();
            var paymentViewModel = mapper.Map<IEnumerable<PaymentHistoryDto>, IEnumerable<PaymentHistoryViewModel>>(paymentDto);

            return Ok(paymentViewModel);
        }
    }
}
