using System;
using System.Threading.Tasks;
using TheraLang.BLL.DataTransferObjects.Donations;

namespace TheraLang.BLL.Interfaces
{
    public interface IDonationService
    {
        Task<DonationDto> GetDonationAsync(Guid donationId);
        Task AddDonationAsync(LiqPayCheckoutDto liqPayCheckoutDto);
    }
}