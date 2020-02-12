using FluentValidation;
using TheraLang.Web.ViewModels;

namespace TheraLang.Web.Validators
{
    public class PageParametersViewModelValidator : AbstractValidator<PagingParametersViewModel>
    {
        public PageParametersViewModelValidator()
        {
            RuleFor(vm => vm.PageNumber).NotNull().GreaterThanOrEqualTo(1);
            RuleFor(vm => vm.PageSize).NotNull().GreaterThanOrEqualTo(1).LessThanOrEqualTo(50);
        }
    }
}
