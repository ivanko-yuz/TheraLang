using System;
using System.Threading.Tasks;
using TheraLang.BLL.DataTransferObjects.Donations;

namespace TheraLang.BLL.Interfaces
{
    public interface IDonationService
    {
        Task<DonationDto> GetDonation(Guid donationId);
        Task<Guid> AddDonation(LiqPayCheckoutDto liqPayCheckoutDto);
    }
}