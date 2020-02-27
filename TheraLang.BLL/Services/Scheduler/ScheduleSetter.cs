using System;

namespace TheraLang.BLL.Services.Scheduler
{
    public class ScheduleSetter
    {
        public static void IntervalInDays(DateTime start, double interval, Action task)
        {
            interval = interval * 24;
            SchedulerService.Instance.ScheduleTask(start, interval, task);

        }
    }
}
