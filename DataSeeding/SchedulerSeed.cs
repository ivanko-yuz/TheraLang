using FluentScheduler;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;


namespace DataSeeding
{
    public static class SchedulerSeed
    {
        public static IWebHost SeedScheduler(this IWebHost host)
        {
            var scope = host.Services.CreateScope();
            JobManager.Initialize(new SchedulerRegistry(scope));
            return host;
        }
    }
}
