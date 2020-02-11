using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace TheraLang.Web.ExceptionHandling
{
    public class ExceptionFilter : IAsyncExceptionFilter
    {
        private readonly IExceptionHandler _errorHandler;

        public ExceptionFilter(IExceptionHandler errorHandler)
        {
            _errorHandler = errorHandler;
        }


        public async Task OnExceptionAsync(ExceptionContext context)
        {
            await _errorHandler.Handle(context);
        }
    }
}