using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace TestDeployemnt
{
    public class TimerGHAction
    {
        [FunctionName("TimerGHAction")]
        public void Run([TimerTrigger("0 */55 * * * *")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
        }
    }
}
