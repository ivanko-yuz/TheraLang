using FluentValidation;
using TheraLang.Web.Validators.ValidationConstants;
using TheraLang.Web.Validators.ValidationRules;
using TheraLang.Web.ViewModels.NewsViewModels;

namespace TheraLang.Web.NewsValidators.Validators
{
    public class NewsCreateViewModelValidator : AbstractValidator<NewsCreateViewModel>
    {
        public NewsCreateViewModelValidator()
        {
            RuleFor(x => x.Title).NotNull().NotEmpty().MaximumLength(NewsValidationConstants.MaxTitleSize);
            RuleFor(x => x.Text).NotNull().NotEmpty().MaximumLength(NewsValidationConstants.MaxTextSize);
            RuleFor(x => x.MainImage).NotNull().IsImage();
            RuleFor(x => x.ContentImages).ForEach(img => img.IsImage());
        }
    }
}