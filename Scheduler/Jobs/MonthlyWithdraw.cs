using FluentScheduler;
using System.Net.Http;

namespace Scheduler.Jobs
{
    public class MonthlyWithdraw : IJob
    {
        public async void Execute()
        {
            var htppClient = HttpClientFactory.Create();
            await htppClient.PostAsync("http://localhost:5000/api/payment", null);
        }
    }
}
