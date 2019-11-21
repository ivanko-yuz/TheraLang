using System;
using System.Collections.Generic;
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
            return LiqPayHelper.GetLiqPayCheckoutModel(donationAmount, projectId);
        }

        public Donation GetDonation(string donationId)
        {
            Donation donation = _unitOfWork.Repository<Donation>().Get().SingleOrDefault(x => x.OrderId == donationId);
            return donation;
        }

        public async Task CheckLiqPayResponse(int projectId, string donationId, string data, string signature)
        {
            byte[] responseData = Convert.FromBase64String(data);
            string decodedString = Encoding.UTF8.GetString(responseData);
            string mySignature = LiqPayHelper.GetLiqPaySignature(data);
            if (mySignature != signature)
            {
                throw new Exception($"Error when checking LiqPay signature, {nameof(signature)} is not original ");
            }
            Donation donation = JsonConvert.DeserializeObject<Donation>(decodedString);
            donation.ProjectId = projectId;
            donation.OrderId = donationId;
            await _unitOfWork.Repository<Donation>().Add(donation);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
