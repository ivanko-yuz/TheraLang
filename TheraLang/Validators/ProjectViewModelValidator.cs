using System;
using System.Linq.Expressions;
using FluentValidation;
using TheraLang.Models;

namespace TheraLang.Validators
{
    public class ProjectViewModelValidator: AbstractValidator<ProjectViewModel>
    {
        private static string ValidateStringLengthMessage =>
        "The field {PropertyName} has to be less than {MinLength} and more than {MaxLength}. Current length is {TotalLength}";

        public ProjectViewModelValidator()
        {
            ValidateStringLength(p => p.Name, 3, 30);
            ValidateStringLength(p => p.Type, 3, 30);
        }

        private void ValidateStringLength(Expression<Func<ProjectViewModel, string>> expression, int minLength, int maxLength)
        {
            RuleFor(expression)
                .NotEmpty()
                .Length(minLength, maxLength)
                .WithMessage(ValidateStringLengthMessage);
        }
    }
}