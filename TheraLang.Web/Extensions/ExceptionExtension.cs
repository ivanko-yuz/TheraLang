﻿using System;
using System.Net;
using Common.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using TheraLang.Web.ExceptionHandling;
using TheraLang.Web.ExceptionHandling.ExceptionHandlingOptions;

namespace TheraLang.Web.Extensions
{
    public static class ExceptionExtension
    {
        public static IServiceCollection AddExceptionHandler(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IExceptionHandler, ExceptionHandler>();
            var options = new Action<ExceptionHandlerOptions>(handlerOptions =>
            {
                handlerOptions.DefaultOptionsForUnhandled = new ExceptionResponseOptions()
                    .WithCode(HttpStatusCode.InternalServerError)
                    .WithBody(context => new JsonResult(new
                    {
                        Category = "Unhandled",
                        Exception = context.Exception.GetType().ToString(),
                        context.Exception.StackTrace
                    }));

                handlerOptions.DefaultOptionsForHandled = new ExceptionResponseOptions()
                    .WithCode(HttpStatusCode.InternalServerError)
                    .WithBody(context => new JsonResult(new
                    {
                        Category = "Handled",
                        Exception = context.Exception.GetType().ToString()
                    }));

                handlerOptions.Map<NotFoundException>(responseOpts =>
                {
                    responseOpts.WithCode(HttpStatusCode.NotFound)
                        .WithBody(context => new JsonResult(new
                        {
                            Category = "Custom",
                            context.Exception.Message
                        }));
                });

                handlerOptions.Map<ArgumentNullException>(responseOpts =>
                {
                    responseOpts.WithCode(HttpStatusCode.BadRequest)
                        .WithBody(context => new JsonResult(new
                        {
                            Category = "Custom",
                            context.Exception.Message,
                            context.Exception.StackTrace
                        }));
                });
            });
            serviceCollection.Configure(options);
            return serviceCollection;
        }
    }
}