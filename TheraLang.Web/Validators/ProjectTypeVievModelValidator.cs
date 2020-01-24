using FluentValidation;
using System;
using System.Linq.Expressions;
using TheraLang.Web.ViewModels;

namespace TheraLang.Web.Validators
{
    public class ProjectTypeVievModelValidator :  AbstractValidator<ProjectTypeViewModel>
    {
        private static string ValidateStringLengthMessage =>
        "The field {PropertyName} has to be less than {MinLength} and more than {MaxLength}. Current length is {TotalLength}";
        public ProjectTypeVievModelValidator()
        {
            ValidateStringLength(p => p.TypeName, 3, 40);            
        }

        private void ValidateStringLength(Expression<Func<ProjectTypeViewModel, string>> expression, int minLength, int maxLength)
        {
            RuleFor(expression)
                .NotEmpty()
                .Length(minLength, maxLength)
                .WithMessage(ValidateStringLengthMessage);
        }
    }
}
