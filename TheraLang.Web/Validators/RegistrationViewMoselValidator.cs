﻿using FluentValidation;
using TheraLang.Web.Validators.ValidationRules;
using TheraLang.Web.ViewModels;

namespace TheraLang.Web.Validators.ValidationRules
{
    public class RegistrationViewMoselValidator: AbstractValidator<UserAllViewModel>
    {
        public RegistrationViewMoselValidator()
        {
            RuleFor(x => x.FirstName).NotNull().NotEmpty().MinimumLength(3).MaximumLength(50);
            RuleFor(x => x.LastName).NotNull().NotEmpty().MinimumLength(5).MaximumLength(50);
            RuleFor(x => x.Image).IsSafe();
            RuleFor(s => s.Email).NotEmpty().WithMessage("Email address is required")
                     .EmailAddress().WithMessage("A valid email is required");

        }
    }
}