using FluentValidation;
using TheraLang.Web.ViewModels.Donations;

namespace TheraLang.Web.Validators.DonationValidators
{
    public class LiqPayCheckoutModelRequestValidator: AbstractValidator<LiqPayCheckoutModelRequest>
    {
        public LiqPayCheckoutModelRequestValidator()
        {
            RuleFor(p => p.DonationAmount).GreaterThan(0.0m);
            RuleFor(p => p.ProjectId)
                .GreaterThanOrEqualTo(1)
                .When(p => p.SocietyId == default, ApplyConditionTo.CurrentValidator);;
            RuleFor(p => p.SocietyId)
                .GreaterThanOrEqualTo(1)
                .When(p => p.ProjectId == default, ApplyConditionTo.CurrentValidator);
            RuleFor(p => p.Action).IsInEnum();
            RuleFor(p => p.Currency).IsInEnum();
            RuleFor(p => p.Description).MaximumLength(128);
        }
    }
}