using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using TheraLang.DLL.Entities;
using TheraLang.DLL.Models;

namespace TheraLang.BLL.Services
{
    public interface IDonationService
    {
        LiqPayCheckoutModel GetLiqPayCheckoutModel(string donationAmount, int? projectId, HttpContext context);
        Donation GetDonation(string donationId);
        Task AddDonation(int? projectId, string donationId, string data, string signature);
    }
}
