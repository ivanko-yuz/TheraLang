using System;
using System.Linq.Expressions;
using FluentValidation;
using TheraLang.Web.Models;

namespace TheraLang.Web.Validators
{
    public class ProjectModelValidator: AbstractValidator<ProjectModel>
    {
        private static string ValidateStringLengthMessage =>
        "The field {PropertyName} has to be less than {MinLength} and more than {MaxLength}. Current length is {TotalLength}";

        public ProjectModelValidator()
        {
            ValidateStringLength(p => p.Name, 3, 30);
            RuleFor(p => p.TypeId).GreaterThan(-1)
               .WithMessage("");
        }

        private void ValidateStringLength(Expression<Func<ProjectModel, string>> expression, int minLength, int maxLength)
        {
            RuleFor(expression)
                .NotEmpty()
                .Length(minLength, maxLength)
                .WithMessage(ValidateStringLengthMessage);
        }
    }
}