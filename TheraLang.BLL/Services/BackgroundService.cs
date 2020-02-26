using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TheraLang.BLL.Services
{
    public class BackgroundServicer : BackgroundService
    {
        private readonly ILogger<BackgroundServicer> _logger;
        private int executionCount = 0;
        private Timer _timer;
        public BackgroundServicer(ILogger<BackgroundServicer> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                DoWork();
                await Task.Delay(TimeSpan.FromSeconds(5), stoppingToken);
            }
        }


        private void DoWork()
        {
            var count = Interlocked.Increment(ref executionCount);

            System.Diagnostics.Debug.Write($"\nTimed Hosted Service is working. Count: {count}");
        }
    }
}
