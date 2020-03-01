using FluentScheduler;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataSeeding
{
    public static class SchedulerSeed
    {
        public static IWebHost SeedScheduler(this IWebHost host)
        {
            var scope = host.Services.CreateScope();
            
                try
                {
                    JobManager.Initialize(new SchedulerRegistry(scope));
                }
                catch (Exception ex)
                {
                    //logger.LogError(ex, "An error occurred seeding the DB.");
                }
            

            return host;
        }
    }
}
