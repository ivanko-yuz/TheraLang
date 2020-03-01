using Common.Exceptions;
using FluentScheduler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheraLang.BLL.Interfaces;

namespace TheraLang.BLL.Services
{
    public class PaymentService : IJob
    {
        private static decimal _paymentSum = 100;
        private readonly IMemberFeeService _memberFeeService;
        private readonly IUserService _userService;

        public PaymentService(IMemberFeeService memberFeeService, IUserService userService)
        {
            _memberFeeService = memberFeeService;
            _userService = userService;
        }


        private async Task<IEnumerable<Guid>> GetMembersId()
        {
            var users = await _userService.GetAllUsers();
            if (users == null)
            {
                throw new NotFoundException("Users not found");
            }
            var membersId = users.Where(i => i.RoleName == "Member")
                .Select(i => i.UserDetailsId);
 
            return membersId;
        }

        public async void Execute()
        {
            var ids = await GetMembersId();
            foreach (var id in ids)
            {
                var user = await _userService.GetUserDetailsById(id);
                if (user == null)
                {
                    throw new NotFoundException("User details not found");
                }
                user.Balance += _paymentSum;
                await _userService.Update(user, id);
            }
        }
    }
}
