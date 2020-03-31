using FluentValidation;
using TheraLang.Web.ViewModels;

namespace TheraLang.Web.Validators
{
    public class MemberFeeViewModelValidators: AbstractValidator<MemberFeeViewModel>
    {
        public MemberFeeViewModelValidators()
        {
            RuleFor(x => x.FeeDate).NotNull();
            RuleFor(x => x.FeeAmount).GreaterThan(0);
        }
    }
}
