using FluentValidation;
using TheraLang.Web.ViewModels;

namespace TheraLang.Web.Validators
{
    public class PaymentHistoryViewModelValidator : AbstractValidator<PaymentHistoryViewModel>
    {
        public PaymentHistoryViewModelValidator()
        {
            RuleFor(x => x.Description).IsInEnum();
            RuleFor(x => x.Saldo).NotNull();
            RuleFor(x => x.UserName).NotNull();
            RuleFor(x => x.UserId).NotNull();
        }
    }
}
