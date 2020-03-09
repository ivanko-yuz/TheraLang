using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TheraLang.BLL.Interfaces;
using TheraLang.BLL.LiqPay;
using TheraLang.BLL.Services;

namespace TheraLang.Web.Extensions
{
    public static class LiqPayExtension
    {
        public static IServiceCollection AddLiqPayServices(this IServiceCollection services, Action<LiqPayKeys> options)
        {
            services.AddTransient<ILiqPayService, LiqPayService>();
            services.Configure(options);
            return services;
        }
        
        public static IServiceCollection AddLiqPayServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<ILiqPayService, LiqPayService>();
            services.Configure<LiqPayKeys>(configuration);
            return services;
        }
    }
}