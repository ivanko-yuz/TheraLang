using System;
using System.Threading.Tasks;
using Common.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using TheraLang.Web.ExceptionHandling.ExceptionHandlingOptions;

namespace TheraLang.Web.ExceptionHandling
{
    public class ExceptionHandler : IExceptionHandler
    {
        private readonly ILoggerFactory _loggerFactory;
        private readonly ExceptionHandlerOptions _handlerOptions;

        public ExceptionHandler(IOptions<ExceptionHandlerOptions> handlerOptions, ILoggerFactory loggerFactory)
        {
            _loggerFactory = loggerFactory;
            _handlerOptions = handlerOptions.Value;
        }

        public Task Handle(ExceptionContext filterContext)
        {
            var logger = _loggerFactory.CreateLogger(filterContext.ActionDescriptor.DisplayName);


            var details = new
            {
                Exception = filterContext.Exception.GetType().FullName,
                filterContext.Exception.Message,
                UserId = filterContext.HttpContext.User.FindFirst("Id")?.Value ?? "Anonymous",
                Route = filterContext.HttpContext.Request.Path.ToString(),
                filterContext.Exception.StackTrace
            };


            logger.LogError(
                $"{details.Exception} at {details.Route} by {details.UserId} Message: {details.Message}\n"
                + $"\tStackTrace: {details.StackTrace}");

            var responseOptions = GetOptions(filterContext.Exception.GetType());

            filterContext.ExceptionHandled = true;
            filterContext.HttpContext.Response.StatusCode = (int) responseOptions.StatusCode;
            filterContext.Result = responseOptions.Formatter.Invoke(filterContext);
            return Task.CompletedTask;
        }

        private ExceptionResponseOptions GetOptions(Type exceptionType)
        {
            if (_handlerOptions.ExceptionResponse.TryGetValue(exceptionType, out var responseOptions))
                return responseOptions;

            if (exceptionType == typeof(ApiException) || exceptionType.IsAssignableFrom(typeof(ApiException)))
                return _handlerOptions.DefaultOptionsForHandled;

            return _handlerOptions.DefaultOptionsForUnhandled;
        }
    }
}