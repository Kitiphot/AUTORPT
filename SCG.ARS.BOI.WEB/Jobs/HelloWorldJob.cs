using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Quartz;

namespace SCG.ARS.BOI.WEB.Jobs {
    [DisallowConcurrentExecution]
    public class HelloWorldJob : IJob {
        private readonly ILogger<HelloWorldJob> _logger;
        public HelloWorldJob (ILogger<HelloWorldJob> logger) {
            _logger = logger;
        }

        public Task Execute (IJobExecutionContext context) {
            _logger.LogInformation ("Hello world!");
            Debug.WriteLine($"{DateTime.Now}: Hello world");
            return Task.CompletedTask;
        }
    }
}