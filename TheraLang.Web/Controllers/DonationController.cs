using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheraLang.DAL.Entities;
using TheraLang.DAL.Models;
using TheraLang.BLL.Services;
using TheraLang.Web.Models;
using System.Linq;
using Microsoft.AspNetCore.Http;
using TheraLang.BLL.Interfaces;

namespace TheraLang.Web.Controllers
{
    [Route("api/donations")]
    [ApiController]
    public class DonationController : ControllerBase
    {
        private readonly IDonationService _donationService;
        public DonationController(IDonationService donationService)
        {
            _donationService = donationService;
        }

        /// <summary>
        /// donation request
        /// </summary>
        /// <param name="donationAmount"></param>
        /// <param name="projectId">a project that you want to donate to</param>
        /// <returns>LiqPayCheckoutModel</returns>
        [HttpGet("{donationAmount}/{projectId?}")]
        public ActionResult<LiqPayCheckoutModel> Get(string donationAmount, int? projectId = null)
        {
            if (projectId == default(int))
            {
                throw new ArgumentException($"{nameof(projectId)} can not be 0");
            }
       
            if (string.IsNullOrEmpty(donationAmount))
            {
                throw new ArgumentException($"{nameof(donationAmount)} can not be null");
            }

            return _donationService.GetLiqPayCheckoutModel(donationAmount, projectId, HttpContext);
        }

        /// <summary>
        /// Get donation by Id
        /// </summary>
        /// <param name="donationId"></param>
        /// <returns>Donation record</returns>
        [HttpGet("transaction/{donationId}")]
        public ActionResult<Donation> Get(string donationId)
        {
            if (String.IsNullOrEmpty(donationId))
            {
                throw new ArgumentException($"{nameof(donationId)} can not be null");
            }

            var donation = _donationService.GetDonation(donationId);
            return Ok(donation);
        }

        /// <summary>
        /// API for LiqPay check in 
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="donationId"></param>
        /// <param name="data"></param>
        /// <param name="signature"></param>
        /// <returns>status code</returns>
        [HttpPost("{donationId}/{projectId?}")]
        public async Task<ActionResult> Post(string donationId, int? projectId, [FromForm]string data, [FromForm]string signature)
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