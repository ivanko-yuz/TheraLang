using DataSeeding;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace TheraLang.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Seed().Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
       
    }
}
