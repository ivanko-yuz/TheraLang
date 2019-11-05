using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using MvcWeb.Models;

namespace MvcWeb.Helpers
{
    public static class ExceptionHelper
    {
        public static void ConfigureExceptionHandler(this IApplicationBuilder app, ILoggerFactory loggerFactory,
            bool useQuietRespond)
        {
            app.UseExceptionHandler(builder =>
            {
                builder.Run(async context =>
                {
                    var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                    if (contextFeature != null)
                    {
                        var error = contextFeature.Error;

                        loggerFactory
                            .CreateLogger("ExceptionHelper")
                            .LogError($"Something went wrong: {error}");

                        var exceptionType = error.GetType();
                        var details = GetExceptionDetails(exceptionType);
                        await context.Respond(details, useQuietRespond);
                    }
                });
            });
        }

        private static ErrorDetails GetExceptionDetails(Type exceptionType)
        {
            var status = HttpStatusCode.InternalServerError;
            var message = "Internal Server Error.";

            if (exceptionType == typeof(UnauthorizedAccessException))
            {
                message = "Unauthorized Access";
                status = HttpStatusCode.Unauthorized;
            }
            else if (exceptionType == typeof(NotImplementedException))
            {
                message = "A server error occurred.";
                status = HttpStatusCode.NotImplemented;
            }

            return new ErrorDetails
            {
                StatusCode = (int) status,
                Message = message
            };
        }

        private static Task Respond(this HttpContext httpContext, ErrorDetails errorDetails, bool useQuietRespond)
        {
            return useQuietRespond
                ? httpContext.RespondCode(errorDetails)
                : httpContext.RespondJsonMessage(errorDetails);
        }

        private static Task RespondJsonMessage(this HttpContext httpContext, ErrorDetails errorDetails)
        {
            httpContext.Response.StatusCode = (int) HttpStatusCode.InternalServerError;
            httpContext.Response.ContentType = "application/json";
            return httpContext.Response.WriteAsync(errorDetails.ToString());
        }

        private static Task RespondCode(this HttpContext httpContext, ErrorDetails errorDetails)
        {
            httpContext.Response.StatusCode = errorDetails.StatusCode;
            return httpContext.Response.WriteAsync(string.Empty);
        }
    }
}