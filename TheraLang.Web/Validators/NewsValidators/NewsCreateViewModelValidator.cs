using FluentValidation;
using TheraLang.Web.Validators.ValidationRules;
using TheraLang.Web.ViewModels.NewsViewModels;

namespace TheraLang.Web.NewsValidators.Validators
{
    public class NewsCreateViewModelValidator : AbstractValidator<NewsCreateViewModel>
    {
        public NewsCreateViewModelValidator()
        {
            RuleFor(x => x.Title).NotNull().MinimumLength(3).MaximumLength(500);
            RuleFor(x => x.Text).NotNull().MinimumLength(5).MaximumLength(50000);
            RuleFor(x => x.MainImage).NotNull().NotEmpty().IsImage();
            RuleFor(x => x.ContentImages).ForEach(img => img.IsImage());
        }
    }
}