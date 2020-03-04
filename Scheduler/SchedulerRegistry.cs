using FluentScheduler;
using Scheduler.Jobs;

namespace Scheduler
{
    public class SchedulerRegistry : Registry
    {
        public SchedulerRegistry()
        {
            Schedule<MonthlyWithdraw>().ToRunEvery(5).Seconds();
        }
    }
}
