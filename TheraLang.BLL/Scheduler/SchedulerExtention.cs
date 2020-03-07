using FluentScheduler;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace TheraLang.BLL.Scheduler
{
    public static class SchedulerExtention
    {
        public static IWebHost StartScheduler(this IWebHost host)
        {
            var scope = host.Services.CreateScope();
            JobManager.Initialize(new SchedulerRegistry(scope));
            return host;
        }
    }
}
