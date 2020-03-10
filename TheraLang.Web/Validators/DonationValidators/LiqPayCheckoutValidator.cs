using FluentValidation;
using TheraLang.Web.ViewModels.Donations;

namespace TheraLang.Web.Validators.DonationValidators
{
    public class LiqPayCheckoutValidator: AbstractValidator<LiqPayCheckoutViewModel>
    {
        public LiqPayCheckoutValidator()
        {
            RuleFor(vm => vm.Data).NotNull();
            RuleFor(vm => vm.Signature).NotNull();
        }
    }
}