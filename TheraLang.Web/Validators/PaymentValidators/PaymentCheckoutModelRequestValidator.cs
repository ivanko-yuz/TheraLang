using FluentValidation;
using TheraLang.Web.ViewModels.Payment;

namespace TheraLang.Web.Validators.DonationValidators
{
    public class PaymentCheckoutModelRequestValidator: AbstractValidator<PaymentCheckoutModelRequest>
    {
        public PaymentCheckoutModelRequestValidator()
        {
            RuleFor(p => p.DonationAmount).GreaterThan(0.0m);
            RuleFor(p => p.Action).IsInEnum();
            RuleFor(p => p.Currency).IsInEnum();
            RuleFor(p => p.Description).MaximumLength(128);
        }
    }
}