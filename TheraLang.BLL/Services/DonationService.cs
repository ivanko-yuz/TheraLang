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

        public async Task<LiqPayCheckoutDto> GetLiqPayCheckoutModelAsync(string donationAmount, int? projectId,
            HttpContext context)
        {
            try
            {
                var liqPayCheckoutDto = LiqPayHelper.GetLiqPayCheckoutModel(donationAmount, projectId, context);

                return liqPayCheckoutDto;
            }
            catch (Exception ex)
            {
                throw new Exception(
                    $"Error while generation a request to LiqPay platform, {nameof(donationAmount)} or {nameof(projectId)} is invalid ",
                    ex);
            }
        }

        public async Task<DonationDto> GetDonationAsync(string donationId)
        {
            try
            {
                Donation donation = await _unitOfWork.Repository<Donation>().GetAsync(x => x.DonationId == donationId);

                var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Donation, DonationDto>()).CreateMapper();
                var projectsDto = mapper.Map<Donation, DonationDto>(donation);

                return projectsDto;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error while receiving a donation by {nameof(donationId)}: {donationId} ", ex);
            }
        }

        public async Task AddDonationAsync(int? projectId, string donationId, string data, string signature)
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
                    var society = await _unitOfWork.Repository<Society>().GetAsync();
                    if (society == null)
                        throw new ArgumentNullException($"Society with {nameof(society.Id)} not found");

                    donation.SocietyId = society.Id;
                }

                await _unitOfWork.Repository<Donation>().AddAsync(donation);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error, while adding the donation, {nameof(donationId)}: {donationId} ", ex);
            }
        }
    }
}