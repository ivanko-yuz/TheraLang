using System;
using System.IO;
using System.Threading;
using DataSeeding;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Serilog;
using TheraLang.BLL.Services.Scheduler;

namespace TheraLang.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .AddEnvironmentVariables()
                .Build();

            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(configuration)
                .CreateLogger();

            ScheduleSetter.IntervalInSeconds(new DateTime(2020, 2, 29), 5, () => {
                Log.Error($"staaart {Thread.CurrentThread.ManagedThreadId}");
                System.Diagnostics.Debug.WriteLine($"staaart {Thread.CurrentThread.ManagedThreadId}");
            });
            try
            {
                BuildWebHost(args).Seed().Run();
            }
            catch (Exception e)
            {
                Log.Fatal(e, "Host terminated unexpectedly");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        public static IWebHost BuildWebHost(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseSerilog()
                .Build();
        }
    }
}