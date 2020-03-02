using Common.Exceptions;
using FluentScheduler;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.BLL.Interfaces;
using TheraLang.DAL.Entities;
using TheraLang.DAL.UnitOfWork;

namespace TheraLang.BLL.Services
{
    public class PaymentService : IJob
    { 
        private readonly IMemberFeeService _memberFeeService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPaymentHistoryService _paymentHistoryService;
        public PaymentService(IMemberFeeService memberFeeService, IUnitOfWork unitOfWork, IPaymentHistoryService paymentHistoryService)
        {
            _memberFeeService = memberFeeService;
            _unitOfWork = unitOfWork;
            _paymentHistoryService = paymentHistoryService;
        }

        private async Task<IEnumerable<UserDetails>> GetAllMembers()
        {
            var users = await _unitOfWork.Repository<UserDetails>().GetAll()
                .Where(i => i.User.Role.Name == "Member")
                .ToListAsync();

            if (users == null)
            {
                throw new NotFoundException("Users not found");
            }

            return users;
        }

        private async Task<decimal> GetFee()
        {
            var fees = await _memberFeeService.GetMemberFeesAsync();

            return -fees.Where(f => f.FeeDate <= DateTime.Now).LastOrDefault().FeeAmount;
        }

        public async void Execute()
        {
            var description = "Monthly fee";
            var members = await GetAllMembers();
            decimal paymentSum = await GetFee();

            if (members == null)
            {
                throw new NotFoundException("User details not found");
            }

            PaymentHistory paymentHistory = new PaymentHistory();
            List<UserDetails> updatedUsers = new List<UserDetails>();
            List<PaymentHistory> updatedHistory = new List<PaymentHistory>();


            foreach (var member in members)
            {

                member.Balance += paymentSum;  

                paymentHistory.Date = DateTime.Now;
                paymentHistory.Description = description;
                paymentHistory.Saldo = paymentSum;
                paymentHistory.UserId = member.UserDetailsId;
                paymentHistory.CurrentBalance = member.Balance;

                updatedUsers.Add(member);
                updatedHistory.Add(paymentHistory);
            }

            _unitOfWork.Repository<UserDetails>().UpdateRange(updatedUsers);
            _unitOfWork.Repository<PaymentHistory>().AddRange(updatedHistory);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
