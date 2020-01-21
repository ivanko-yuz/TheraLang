using FluentValidation;
using TheraLang.DLL.Models;

namespace TheraLang.Web.Validators
{
        public class ResourceViewModelValidator : AbstractValidator<ResourceViewModel>
        {
            public ResourceViewModelValidator()
            {
                RuleFor(x => x.Name).NotNull().NotEmpty().MinimumLength(3).MaximumLength(50);
                RuleFor(x => x.Description).NotNull().NotEmpty().MinimumLength(5).MaximumLength(5000);
                RuleFor(x => x.Url).MaximumLength(200);
                RuleFor(x => x.CategoryId).NotNull().NotEmpty();
            }
        }
}
