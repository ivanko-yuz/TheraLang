using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using MvcWeb.TheraLang.Entities;
using MvcWeb.TheraLang.Models;
using MvcWeb.TheraLang.Services;
using Newtonsoft.Json;

namespace MvcWeb.TheraLang.Controllers
{
    [Route("api/donation")]
    [EnableCors("MyPolicy")]
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
            return _donationService.GetLiqPayCheckoutModel(donationAmount, projectId);
        }


        [HttpGet("{donationId}")]
        public ActionResult<Donation> Get(string donationId)
        {
            var donation = _donationService.GetDonation(donationId);
            return donation;        
        }


        [HttpPost("{projectId}/{donationId}")]
        public async Task<ActionResult> Post(int projectId, string donationId, [FromForm]string data, [FromForm]string signature)
        {
            await _donationService.CheckLiqPayResponse(projectId, donationId, data, signature);        
            return Ok();
        }

    }
}