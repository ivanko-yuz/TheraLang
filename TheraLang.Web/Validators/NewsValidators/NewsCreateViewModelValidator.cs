﻿using FluentValidation;
using System.Linq;
using TheraLang.Web.Validators.ValidationRules;
using TheraLang.Web.ViewModels.NewsViewModels;

namespace TheraLang.Web.NewsValidators.Validators
{
    public class NewsCreateViewModelValidator : AbstractValidator<NewsCreateViewModel>
    {
        public NewsCreateViewModelValidator()
        {
            RuleFor(x => x.Title).NotNull().NotEmpty().MinimumLength(3).MaximumLength(250);
            RuleFor(x => x.Text).NotNull().NotEmpty().MinimumLength(5).MaximumLength(10000);
            RuleFor(x => x.MainImage).NotNull().NotEmpty().IsImage();
            RuleFor(x => x.ContentImages).NotNull().ForEach(img => img.IsImage());
        }
    }
}