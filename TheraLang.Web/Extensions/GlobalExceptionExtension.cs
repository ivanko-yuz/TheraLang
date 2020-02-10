using GlobalExceptionHandler.WebApi;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace TheraLang.Web.Extensions
{
    public static class GlobalExceptionExtension
    {
        public static void AddGlobalExceptionHandling(this IApplicationBuilder app)
        {
            app.UseGlobalExceptionHandler(opts =>
            {
                opts.ContentType = "application/json";
                opts.ResponseBody(exception => JsonConvert.SerializeObject(new
                {
                    exception.Message,
                    exception.StackTrace
                }));
            });
        }
    }
}