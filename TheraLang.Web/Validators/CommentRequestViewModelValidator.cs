using FluentValidation;
using TheraLang.Web.Validators.ValidationConstants;
using TheraLang.Web.ViewModels.CommentViewModels;

namespace TheraLang.Web.Validators
{
    public class CommentRequestViewModelValidator : AbstractValidator<CommentRequestViewModel>
    {
        public CommentRequestViewModelValidator()
        {
            RuleFor(c => c.Text).NotNull().NotEmpty().MaximumLength(CommentValidationConstants.MaxTextSize);
        }
    }
}
