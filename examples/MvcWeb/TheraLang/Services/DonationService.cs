using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcWeb.TheraLang.Entities;
using MvcWeb.TheraLang.Models;
using MvcWeb.TheraLang.UnitOfWork;
using Newtonsoft.Json;

namespace MvcWeb.TheraLang.Services
{
    public class DonationService : IDonationService
    {
        private readonly IUnitOfWork _unitOfWork;

        public DonationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public LiqPayCheckoutModel GetLiqPayCheckoutModel(string donationAmount, int projectId)
        {
            try
            {
                return LiqPayHelper.GetLiqPayCheckoutModel(donationAmount, projectId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error while generation a request to LiqPay platform, {nameof(donationAmount)} or {nameof(projectId)} is invalid ", ex);
            }
           
        }

        public Donation GetDonation(string donationId)
        {
            try
            {
                Donation donation = _unitOfWork.Repository<Donation>().Get().SingleOrDefault(x => x.DonationId == donationId);
                return donation;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error while receiving a donation by {nameof(donationId)}: {donationId} ", ex);
            }
           
        }

        public async Task AddDonation(int projectId, string donationId, string data, string signature)
        {
            try
            {
                byte[] responseData = Convert.FromBase64String(data);
                string decodedString = Encoding.UTF8.GetString(responseData);                           
                Donation donation = JsonConvert.DeserializeObject<Donation>(decodedString);
                donation.ProjectId = projectId;
                donation.DonationId = donationId;
                await _unitOfWork.Repository<Donation>().Add(donation);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error, while adding the donation, {nameof(donationId)}: {donationId} ", ex);
            }
        
        }
    }
}
