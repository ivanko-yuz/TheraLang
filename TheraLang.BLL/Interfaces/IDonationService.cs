using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using TheraLang.BLL.DataTransferObjects;

namespace TheraLang.BLL.Interfaces
{
    public interface IDonationService
    {
        Task<LiqPayCheckoutDto> GetLiqPayCheckoutModelAsync(string donationAmount, int? projectId, HttpContext context);
        Task<DonationDto> GetDonationAsync(string donationId);
        Task AddDonationAsync(int? projectId, string donationId, string data, string signature);
    }
}
