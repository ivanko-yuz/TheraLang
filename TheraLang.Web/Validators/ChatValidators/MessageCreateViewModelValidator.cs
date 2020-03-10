using FluentValidation;
using TheraLang.Web.ViewModels.Chat;

namespace TheraLang.Web.Validators.ChatValidators
{
    public class MessageCreateViewModelValidator : AbstractValidator<MessageCreateViewModel>
    {
        public MessageCreateViewModelValidator()
        {
            RuleFor(x => x.Text).NotNull().NotEmpty().MinimumLength(1).MaximumLength(256);
            RuleFor(x => x.ChatId).NotEmpty().GreaterThanOrEqualTo(1);
        }
    }
}
