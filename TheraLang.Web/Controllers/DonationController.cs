using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheraLang.DLL.Entities;
using TheraLang.DLL.Models;
using TheraLang.DLL.Services;

namespace TheraLang.Web.Controllers
{
    [Route("api/donation")]
    [ApiController]
    public class DonationController : Controller
    {
        private readonly IDonationService _donationService;
        public DonationController(IDonationService donationService)
        {
            _donationService = donationService;
        }


        [HttpGet("{donationAmount}/{projectId}")]
        public ActionResult<LiqPayCheckoutModel> Get(string donationAmount, int projectId)
        {
            if (projectId == default)
            {
                throw new ArgumentException($"{nameof(projectId)} can not be 0");
            }
            if (String.IsNullOrEmpty(donationAmount))
            {
                throw new ArgumentException($"{nameof(donationAmount)} can not be null");
            }
            return _donationService.GetLiqPayCheckoutModel(donationAmount, projectId);
        }


        [HttpGet("{donationId}")]
        public ActionResult<Donation> Get(string donationId)
        {
            if (String.IsNullOrEmpty(donationId))
            {
                throw new ArgumentException($"{nameof(donationId)} can not be null");
            }

            var donation = _donationService.GetDonation(donationId);
            return Ok(donation);        
        }


        [HttpPost("{projectId}/{donationId}")]
        public async Task<ActionResult> Post(int projectId, string donationId, [FromForm]string data, [FromForm]string signature)
        {
            if (string.IsNullOrEmpty(data))
            {
                throw new ArgumentException($"{nameof(data)} can not be null");
            }
            if (string.IsNullOrEmpty(signature))
            {
                throw new ArgumentException($"{nameof(signature)} can not be null");
            }

            string mySignature = LiqPayHelper.GetLiqPaySignature(data);
            if (mySignature != signature)
            {
                throw new Exception($"Error, while checking LiqPay response signature, the {nameof(signature)} was not authenticated ");
            }

            await _donationService.AddDonation(projectId, donationId, data, signature);        
            return Ok();
        }

    }
}