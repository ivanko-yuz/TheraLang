using FluentValidation;
using TheraLang.Web.ViewModels.Donations;

namespace TheraLang.Web.Validators.DonationValidators
{
    public class PaymentCheckoutInfoValidator : AbstractValidator<LiqPayCheckoutInfoViewModel>
    {
        public PaymentCheckoutInfoValidator()
        {
            RuleFor(p => p.ProjectId)
                .GreaterThanOrEqualTo(1)
                .When(p => p.SocietyId == default, ApplyConditionTo.CurrentValidator);;
            RuleFor(p => p.SocietyId)
                .GreaterThanOrEqualTo(1)
                .When(p => p.ProjectId == default, ApplyConditionTo.CurrentValidator);
        }
    }
}