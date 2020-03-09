using Common.Enums;
using Common.Exceptions;
using FluentScheduler;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheraLang.DAL.Entities;
using TheraLang.DAL.UnitOfWork;

namespace TheraLang.BLL.Services
{
    public class PaymentService : IJob 
    {
        private readonly IUnitOfWork _unitOfWork;
        public PaymentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        private async Task<IEnumerable<UserDetails>> GetAllMembers()
        {
            var users = await _unitOfWork.Repository<UserDetails>().GetAll()
                .Where(i => i.User.Role.Name == "Member")
                .ToListAsync();

            return users;
        }

        private async Task<decimal> GetFee()
        {
            var fee = await _unitOfWork.Repository<MemberFee>()
                .GetAll()
                .Where(f => f.FeeDate <= DateTime.Now)
                .LastOrDefaultAsync();
            if (fee == null)
            {
                return 0;
            }
            return -fee.FeeAmount;
        }

        public async void Execute()
        {
            var members = await GetAllMembers();
            decimal paymentSum = await GetFee();

            if (members == null)
            {
                throw new NotFoundException("User details not found");
            }

            List<UserDetails> updatedUsers = new List<UserDetails>();
            List<PaymentHistory> updatedHistory = new List<PaymentHistory>();
            foreach (var member in members)
            {

                member.Balance += paymentSum;

                var paymentHistory = new PaymentHistory()
                {
                    Date = DateTime.Now,
                    Description = PaymentDescription.MonthlyFee,
                    Saldo = paymentSum,
                    UserId = member.UserDetailsId,
                    CurrentBalance = member.Balance
                };

                updatedUsers.Add(member);
                updatedHistory.Add(paymentHistory);
            }

            _unitOfWork.Repository<UserDetails>().UpdateRange(updatedUsers);
            _unitOfWork.Repository<PaymentHistory>().AddRange(updatedHistory);
            await _unitOfWork.SaveChangesAsync();
        }

    }
}
