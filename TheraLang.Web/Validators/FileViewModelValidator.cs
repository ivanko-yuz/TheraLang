using FluentValidation;
using TheraLang.Web.Validators.ValidationRules;
using TheraLang.Web.ViewModels;

namespace TheraLang.Web.Validators
{
    public class FileViewModelValidator: AbstractValidator<FileViewModel>
    {
        public FileViewModelValidator()
        {
            RuleFor(vm => vm.File).NotNull().IsSafe();
        }
    }
}