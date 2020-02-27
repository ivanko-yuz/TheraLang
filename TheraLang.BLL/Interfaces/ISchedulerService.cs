using System;
using System.Collections.Generic;
using System.Text;

namespace TheraLang.BLL.Interfaces
{
    public interface ISchedulerService
    {
        void ScheduleTask(DateTime start, double intervalInHour, Action task);
    }
}
