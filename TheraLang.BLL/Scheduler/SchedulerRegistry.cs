﻿using FluentScheduler;
using Microsoft.Extensions.DependencyInjection;
using System;
using TheraLang.BLL.Services;

namespace TheraLang.BLL.Scheduler
{
    public class SchedulerRegistry : Registry
    {
        public SchedulerRegistry(IServiceScope service)
        {
            Schedule(service.ServiceProvider.GetRequiredService<SchedulerService>())
                .ToRunEvery(1)
                .Months()
                .OnTheFirst(DayOfWeek.Monday)
                .At(0, 0);
        }
    }
}
