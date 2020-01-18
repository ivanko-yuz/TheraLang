using FluentValidation;
using System;
using System.Linq.Expressions;
using TheraLang.DAL.Models;

namespace TheraLang.Web.Validators
{
    public class ProjectTypeVievModelValidator :  AbstractValidator<ProjectTypeModel>
    {
        private static string ValidateStringLengthMessage =>
        "The field {PropertyName} has to be less than {MinLength} and more than {MaxLength}. Current length is {TotalLength}";
        public ProjectTypeVievModelValidator()
        {
            ValidateStringLength(p => p.TypeName, 3, 40);            
        }

        private void ValidateStringLength(Expression<Func<ProjectTypeModel, string>> expression, int minLength, int maxLength)
        {
            RuleFor(expression)
                .NotEmpty()
                .Length(minLength, maxLength)
                .WithMessage(ValidateStringLengthMessage);
        }
    }
}
