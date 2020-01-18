using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using TheraLang.DAL.Entities;
using TheraLang.DAL.Models;

namespace TheraLang.BLL.Interfaces
{
    public interface IDonationService
    {
        LiqPayCheckoutModel GetLiqPayCheckoutModel(string donationAmount, int? projectId, HttpContext context);
        Donation GetDonation(string donationId);
        Task AddDonation(int? projectId, string donationId, string data, string signature);
    }
}
