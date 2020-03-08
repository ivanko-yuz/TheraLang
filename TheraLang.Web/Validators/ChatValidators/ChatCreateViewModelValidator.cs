using FluentValidation;
using TheraLang.Web.ViewModels.Chat;

namespace TheraLang.Web.Validators.ChatValidators
{
    public class ChatCreateViewModelValidator : AbstractValidator<ChatCreateViewModel>
    {
        public ChatCreateViewModelValidator()
        {
            RuleFor(x => x.ChatName).NotNull().NotEmpty().MinimumLength(3).MaximumLength(55);
        }
    }
}
