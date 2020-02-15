using System.Web.WebPages;
using FluentValidation;
using TheraLang.Web.Validators.ValidationRules;
using TheraLang.Web.ViewModels;

namespace TheraLang.Web.Validators
{
        public class ResourceViewModelValidator : AbstractValidator<ResourceViewModel>
        {
            public ResourceViewModelValidator()
            {
                RuleFor(x => x.Name).NotNull().NotEmpty().MinimumLength(3).MaximumLength(50);
                RuleFor(x => x.Description).NotNull().NotEmpty().MinimumLength(5).MaximumLength(5000);
                RuleFor(x => x.Url).MaximumLength(200).NotEmpty().When(model => model.File == null);
                RuleFor(x => x.CategoryId).NotNull().NotEmpty();
                RuleFor(x => x.File).NotNull().When(model => model.Url.IsEmpty()).IsSafe();
            }
        }
}
