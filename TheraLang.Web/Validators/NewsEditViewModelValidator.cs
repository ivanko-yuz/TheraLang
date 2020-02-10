using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheraLang.Web.Validators.ValidationRules;
using TheraLang.Web.ViewModels.NewsViewModels;

namespace TheraLang.Web.Validators
{
    public class NewsEditViewModelValidator : AbstractValidator<NewsEditViewModel>
    {
        public NewsEditViewModelValidator()
        {
            RuleFor(x => x.Title).NotNull().NotEmpty().MinimumLength(3).MaximumLength(250);
            RuleFor(x => x.Text).NotNull().NotEmpty().MinimumLength(5).MaximumLength(10000);
            RuleFor(x => x.NewMainImage).IsImage().NotNull().NotEmpty().When(model=>model.UploadedMainImageUrl == null);
            RuleFor(x => x.UploadedMainImageUrl).NotNull().NotEmpty().When(model => model.NewMainImage == null);
            RuleFor(x => x.AddedContentImages).ForEach(img => img.IsImage());
            RuleFor(x => x.NotDeletedContentImageUrls).NotNull();
        }
    }
}
