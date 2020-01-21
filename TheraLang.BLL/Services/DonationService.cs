using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.BLL.Interfaces;
using TheraLang.DAL.Entities;
using TheraLang.DAL.Models;
using TheraLang.DAL.UnitOfWork;

namespace TheraLang.BLL.Services
{
    public class DonationService : IDonationService
    {
        private readonly IUnitOfWork _unitOfWork;

        public DonationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public LiqPayCheckoutDto GetLiqPayCheckoutModel(string donationAmount, int? projectId, HttpContext context)
        {
            try
            {
                var liqPayCheckoutDto = LiqPayHelper.GetLiqPayCheckoutModel(donationAmount, projectId, context);

                return liqPayCheckoutDto;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error while generation a request to LiqPay platform, {nameof(donationAmount)} or {nameof(projectId)} is invalid ", ex);
            }
        }

        public DonationDto GetDonation(string donationId)
        {
            try
            {
                Donation donation = _unitOfWork.Repository<Donation>().Get().SingleOrDefault(x => x.DonationId == donationId);

                var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Donation, DonationDto>()).CreateMapper();
                var projectsDto = mapper.Map<Donation, DonationDto>(donation);

                return projectsDto;
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
                var commissionModel = JsonConvert.DeserializeObject<LiqPayCommissionModel>(decodedString);
                Donation donation = JsonConvert.DeserializeObject<Donation>(decodedString);
                donation.Amount -= commissionModel.ReceiverCommission;
                donation.ProjectId = projectId;
                donation.DonationId = donationId;
                if (projectId == null)
                {
                    var society = _unitOfWork.Repository<Society>().Get().FirstOrDefault();
                    if (society == null)
                        throw new ArgumentNullException($"Society with {nameof(society.Id)} not found");

                    donation.SocietyId = society.Id;
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
