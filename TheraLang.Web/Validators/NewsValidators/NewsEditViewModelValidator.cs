using FluentValidation;
using System.Linq;
using TheraLang.Web.Validators.ValidationRules;
using TheraLang.Web.ViewModels.NewsViewModels;

namespace TheraLang.Web.NewsValidators.Validators
{
    public class NewsEditViewModelValidator : AbstractValidator<NewsEditViewModel>
    {
        public NewsEditViewModelValidator()
        {
            RuleFor(x => x.Title).NotNull().NotEmpty().MinimumLength(3).MaximumLength(250);
            RuleFor(x => x.Text).NotNull().NotEmpty().MinimumLength(5).MaximumLength(10000);
            //TODO: Check
            RuleFor(x => x.NewMainImage).IsImage().NotNull().NotEmpty().When(model => model.UploadedMainImageUrl == null);
            RuleFor(x => x.UploadedMainImageUrl).NotNull().NotEmpty().When(model => model.NewMainImage == null);
            RuleFor(x => x.AddedContentImages).ForEach(img => img.IsImage());
            RuleFor(x => x.NotDeletedContentImageUrls).NotNull();
        }
    }
}
