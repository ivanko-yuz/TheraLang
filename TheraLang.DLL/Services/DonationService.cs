using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using TheraLang.DLL.Entities;
using TheraLang.DLL.Models;
using TheraLang.DLL.UnitOfWork;

namespace TheraLang.DLL.Services
{
    public class DonationService : IDonationService
    {
        private readonly IUnitOfWork _unitOfWork;

        public DonationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public LiqPayCheckoutModel GetLiqPayCheckoutModel(string donationAmount, int? projectId, HttpContext context)
        {
            try
            {
                return LiqPayHelper.GetLiqPayCheckoutModel(donationAmount, projectId, context);
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

        public async Task AddDonation(int? projectId, string donationId, string data, string signature)
        {
            try
            {
                byte[] responseData = Convert.FromBase64String(data);
                string decodedString = Encoding.UTF8.GetString(responseData);
                var donationModel = JsonConvert.DeserializeObject<Dictionary<string,object>>(decodedString);
                decimal donationCommission = Convert.ToDecimal(donationModel["receiver_commission"]);
                Donation donation = JsonConvert.DeserializeObject<Donation>(decodedString);
                donation.Amount -= donationCommission;
                donation.ProjectId = projectId;
                donation.DonationId = donationId;
                if (projectId == null)
                {
                    donation.SocietyId = _unitOfWork.Repository<Society>().Get().FirstOrDefault().Id;
                }
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
