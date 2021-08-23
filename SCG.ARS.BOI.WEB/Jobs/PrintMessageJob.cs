using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Quartz;
using SCG.ARS.BOI.WEB.Configuration;
using SCG.ARS.BOI.WEB.Helpers;

namespace SCG.ARS.BOI.WEB.Jobs {
    [DisallowConcurrentExecution]
    public class PrintMessageJob : IJob {
        private static readonly Random Random = new Random ();

        private static SmtpSetting _config;
        private static SmtpClientEx _smtpClient;
        public PrintMessageJob (IOptions<SmtpSetting> config, SmtpClientEx smtpClient) {
            _config = config.Value;
            _smtpClient = smtpClient;
        }

        public Task Execute (IJobExecutionContext context) {
            var color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine ("Greetings from HelloJob!");

            Console.WriteLine ($"{DateTime.Now}: Job message job end");
            Console.ForegroundColor = color;

            return Task.Delay (TimeSpan.FromSeconds (Random.Next (1, 20)));
        }
    }
}