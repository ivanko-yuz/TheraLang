using System;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace TheraLang.Web.ExceptionHandling.ExceptionHandlingOptions
{
    public class ExceptionResponseOptions
    {
        public HttpStatusCode StatusCode { get; set; }
        public Func<ExceptionContext, IActionResult> Formatter { get; set; }

        public ExceptionResponseOptions WithCode(HttpStatusCode statusCode)
        {
            StatusCode = statusCode;
            return this;
        }

        public ExceptionResponseOptions WithBody(Func<ExceptionContext, IActionResult> formatter)
        {
            Formatter = formatter;
            return this;
        }

        public static ExceptionResponseOptions GetDebugDefault()
        {
            return new ExceptionResponseOptions()
            {
                StatusCode = HttpStatusCode.InternalServerError,
                Formatter = DebugFormatter
            };
        }

        public static ExceptionResponseOptions GetProductionDefault()
        {
            return new ExceptionResponseOptions()
            {
                StatusCode = HttpStatusCode.InternalServerError,
                Formatter = ProductionFormatter
            };
        }

        private static IActionResult DebugFormatter(ExceptionContext exceptionContext)
        {
            var exception = exceptionContext.Exception;
            return new JsonResult(new
            {
                exception.Message,
                exception.StackTrace
            });
        }

        private static IActionResult ProductionFormatter(ExceptionContext exceptionContext)
        {
            return new JsonResult(new
            {
                Message = "Internal Server Error"
            });
        }
    }
}