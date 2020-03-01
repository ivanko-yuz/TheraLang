using FluentScheduler;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using TheraLang.BLL.Services;

namespace DataSeeding
{
    public class SchedulerRegistry : Registry
    {
        public SchedulerRegistry(IServiceScope service)
        {
            //Schedule(service.ServiceProvider.GetRequiredService<PaymentService>()).ToRunEvery(1).Months().OnTheFirst(DayOfWeek.Monday).At(0, 0);
            Schedule(service.ServiceProvider.GetRequiredService<PaymentService>()).ToRunNow();
        }
    }
}
