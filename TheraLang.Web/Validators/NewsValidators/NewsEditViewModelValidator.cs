using FluentValidation;
using TheraLang.Web.Validators.ValidationConstants;
using TheraLang.Web.Validators.ValidationRules;
using TheraLang.Web.ViewModels.NewsViewModels;

namespace TheraLang.Web.NewsValidators.Validators
{
    public class NewsEditViewModelValidator : AbstractValidator<NewsEditViewModel>
    {
        public NewsEditViewModelValidator()
        {
            RuleFor(x => x.Title).NotNull().NotEmpty().MaximumLength(NewsValidationConstants.MaxTitleSize);
            RuleFor(x => x.Text).NotNull().NotEmpty().MaximumLength(NewsValidationConstants.MaxTextSize);
            RuleFor(x => x.NewMainImage).IsImage().NotNull()
                .When(model => model.UploadedMainImageUrl == null);
            RuleFor(x => x.UploadedMainImageUrl).NotNull().When(model => model.NewMainImage == null);
            RuleFor(x => x.AddedContentImages).ForEach(img => img.IsImage());
            RuleFor(x => x.NotDeletedContentImageUrls);
        }
    }
}