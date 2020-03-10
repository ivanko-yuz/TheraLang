using FluentValidation;
using TheraLang.Web.ViewModels;
using TheraLang.Web.ViewModels.Resources;

namespace TheraLang.Web.Validators.Resources
{
    public class ResourceTextInfoViewModelValidator : AbstractValidator<ResourceTextInfoViewModel>
    {
        public ResourceTextInfoViewModelValidator()
        {
            RuleFor(x => x.Name).NotNull().NotEmpty().MinimumLength(3).MaximumLength(50);
            RuleFor(x => x.Description).NotNull().NotEmpty().MinimumLength(5).MaximumLength(512);
            RuleFor(x => x.CategoryId).NotNull().NotEmpty();
        }
    }
}