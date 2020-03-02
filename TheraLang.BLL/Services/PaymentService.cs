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

        private async Task<IEnumerable<UserDetails>> GetAllMembersId()
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
            PaymentHistoryDto _paymentHistoryDto = new PaymentHistoryDto();
            var description = "Monthly fee";
            var users = await GetAllMembersId();
            decimal paymentSum = await GetFee();

            foreach (var user in users)
            {
                if (user == null)
                {
                    throw new NotFoundException("User details not found");
                }

                user.Balance += paymentSum;
                _unitOfWork.Repository<UserDetails>().Update(user);

                _paymentHistoryDto.Date = DateTime.Now;
                _paymentHistoryDto.Description = description;
                _paymentHistoryDto.Saldo = paymentSum;
                _paymentHistoryDto.UserId = user.UserDetailsId;

                await _paymentHistoryService.Add(_paymentHistoryDto);
            }
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
