using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheraLang.Web.Validators.ValidationRules;
using TheraLang.Web.ViewModels.NewsViewModels;

namespace TheraLang.Web.Validators
{
    public class NewsCreateViewModelValidator : AbstractValidator<NewsCreateViewModel>
    {
        public NewsCreateViewModelValidator()
        {
            RuleFor(x => x.Title).NotNull().NotEmpty().MinimumLength(3).MaximumLength(250);
            RuleFor(x => x.Text).NotNull().NotEmpty().MinimumLength(5).MaximumLength(10000);
            RuleFor(x => x.NewImages).ForEach(img => img.IsImage());
        }
    }
}
