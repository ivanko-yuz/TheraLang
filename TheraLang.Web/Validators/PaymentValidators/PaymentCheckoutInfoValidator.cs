using FluentValidation;
using TheraLang.Web.ViewModels.Payment;

namespace TheraLang.Web.Validators.PaymentValidators
{
    public class PaymentCheckoutInfoValidator : AbstractValidator<PaymentCheckoutInfoViewModel>
    {
        public PaymentCheckoutInfoValidator()
        {
            RuleFor(p => p.MemberId)
                .NotEmpty();
        }
    }
}