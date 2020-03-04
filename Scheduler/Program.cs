using FluentScheduler;
using System;
using System.Threading;

namespace Scheduler
{
    class Program
    {
        static void Main(string[] args)
        {
            JobManager.Initialize(new SchedulerRegistry());
            Thread.Sleep(Timeout.Infinite);
        }
    }
}
