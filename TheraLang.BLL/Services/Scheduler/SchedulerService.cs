using System;
using System.Collections.Generic;
using System.Threading;

namespace TheraLang.BLL.Services
{
    public class SchedulerService
    {
        private static SchedulerService _instance;
        private List<Timer> _timers = new List<Timer>();
        private SchedulerService() { }
        public static SchedulerService Instance => _instance ?? (_instance = new SchedulerService());
        public void ScheduleTask(DateTime start, double intervalInHour, Action task)
        {
            var dueTime = TimeSpan.FromTicks(start.Subtract(DateTime.Now).Ticks);
            
            var timer = new Timer(x =>
            {   
                task.Invoke();
            }, null, dueTime, TimeSpan.FromHours(intervalInHour));
            _timers.Add(timer);
        }
    }
}
