using System.IO;
using System.Text.RegularExpressions;
using FluentValidation;
using Microsoft.AspNetCore.Http;

namespace TheraLang.Web.Validators.ValidationRules
{
    public static class FileValidationRules
    {
        public static IRuleBuilderInitial<T,IFormFile> IsSafe<T>(this IRuleBuilder<T, IFormFile> ruleBuilder) {

            return ruleBuilder.Custom((file, context) =>
            {
                if (file == null) return;
                var extension = Path.GetExtension(file.FileName);
                var regex = new Regex(@"(.*\.exe)|(.*\.cmd)|(.*\.bat)");
                if (regex.IsMatch(extension))
                {
                    context.AddFailure($"{extension} not allowed");
                }
            });
        }
    }
}