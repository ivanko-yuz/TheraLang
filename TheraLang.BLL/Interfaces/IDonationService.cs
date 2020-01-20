using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using TheraLang.BLL.DataTransferObjects;

namespace TheraLang.BLL.Interfaces
{
    public interface IDonationService
    {
        LiqPayCheckoutDto GetLiqPayCheckoutModel(string donationAmount, int? projectId, HttpContext context);
        DonationDto GetDonation(string donationId);
        Task AddDonation(int? projectId, string donationId, string data, string signature);
    }
}
