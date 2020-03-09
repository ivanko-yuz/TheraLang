using FluentValidation;
using TheraLang.Web.ViewModels.UsersViewModels;

namespace TheraLang.Web.Validators.ValidationRules
{
    public class RegistrationViewMoselValidator : AbstractValidator<UserAllViewModel>
    {
        public RegistrationViewMoselValidator()
        {
            RuleFor(x => x.FirstName).NotNull().NotEmpty().MinimumLength(2).MaximumLength(50);
            RuleFor(x => x.LastName).NotNull().NotEmpty().MinimumLength(2).MaximumLength(50);
            RuleFor(x => x.Image).IsSafe();
            RuleFor(s => s.Email).NotEmpty().WithMessage("Email address is required")
                .EmailAddress().WithMessage("A valid email is required");
        }
    }
}