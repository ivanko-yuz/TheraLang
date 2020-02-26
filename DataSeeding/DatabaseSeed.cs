using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace DataSeeding
{
    public static class DatabaseSeed
    {
        public static IWebHost Seed(this IWebHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                try
                {
                    var dataseed = new DbInitializer();
                    dataseed.Seed(scope);
                }
                catch (Exception)
                {
                    //logger.LogError(ex, "An error occurred seeding the DB.");
                }
            }

            return host;
        }
    }
}