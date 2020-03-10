using Common.Exceptions;
using System.Threading.Tasks;
using TheraLang.BLL.DataTransferObjects.Donations;
using TheraLang.BLL.Interfaces;
using TheraLang.BLL.LiqPay;
using TheraLang.DAL.Entities;
using TheraLang.DAL.UnitOfWork;
using Common.Enums;
using System;
using Microsoft.Extensions.Options;

namespace TheraLang.BLL.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly LiqPayKeys _liqPayInfo;

        public PaymentService(IUnitOfWork unitOfWork, IOptions<LiqPayKeys> liqPayInfo)
        {
            _unitOfWork = unitOfWork;
            _liqPayInfo = liqPayInfo.Value;
        }
        public async Task TopUpBalance(LiqPayCheckoutDto liqPayCheckoutDto)
        {
            var liqPayData = new LiqPayData(liqPayCheckoutDto.Data);
            var liqPaySignature = new LiqPaySignature(liqPayData, _liqPayInfo.PrivateKey);

            if (!await liqPaySignature.Validate(liqPayCheckoutDto.Signature))
            {
                throw new InvalidArgumentException(nameof(liqPayCheckoutDto.Signature),
                    "Invalid signature");
            }

            var user = await _unitOfWork.Repository<UserDetails>()
                    .Get(i => i.UserDetailsId == liqPayCheckoutDto.MemberId);

            if (user == null)
            {
                throw new NotFoundException($"User with id {liqPayCheckoutDto.MemberId}");
            }
            var donation = liqPayData.Donation;

            var commissionModel = liqPayData.Commission;
            donation.Amount -= commissionModel.ReceiverCommission;
            user.Balance += donation.Amount;

            var paymentHistory = new PaymentHistory()
            {
                Description = PaymentDescription.TopUp,
                Saldo = donation.Amount,
                UserId = (Guid)liqPayCheckoutDto.MemberId,
                CurrentBalance = user.Balance
            };

            _unitOfWork.Repository<UserDetails>().Update(user);
            _unitOfWork.Repository<PaymentHistory>().Add(paymentHistory);
            await _unitOfWork.SaveChangesAsync();

        }
    }
}
