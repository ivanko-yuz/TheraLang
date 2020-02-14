using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataSeeding
{
    public static class DatabaseSeed
    {
        public static IWebHost Seed(this IWebHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var serviceProvider = scope.ServiceProvider;

                try
                {
                    Task.Run(async () =>
                    {
                        var dataseed = new DbInitializer();
                        dataseed.Seed(serviceProvider);
                    }).Wait();

                }
                catch (Exception ex)
                {
                    //logger.LogError(ex, "An error occurred seeding the DB.");
                }
            }
            return host;
        }
    }
}
