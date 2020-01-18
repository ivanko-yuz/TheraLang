using FluentValidation;
using TheraLang.DAL.Models;

namespace TheraLang.Web.Validators
{
        public class ResourceViewModelValidator : AbstractValidator<ResourceViewModel>
        {
            public ResourceViewModelValidator()
            {
                RuleFor(x => x.name).NotNull().NotEmpty().MinimumLength(3).MaximumLength(50);
                RuleFor(x => x.description).NotNull().NotEmpty().MinimumLength(5).MaximumLength(5000);
                RuleFor(x => x.url).MaximumLength(200);
                RuleFor(x => x.categoryId).NotNull().NotEmpty();
            }
        }
}
