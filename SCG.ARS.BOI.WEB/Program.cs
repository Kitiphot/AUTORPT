using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using NLog.Web;

namespace SCG.ARS.BOI.WEB {
    public class Program {
        public static void Main (string[] args) {
            var logger = NLog.Web.NLogBuilder.ConfigureNLog ("NLog.config").GetCurrentClassLogger ();
            try {
                //logger.Debug("init main");
                BuildWebHost (args).Run ();
            } catch (Exception) {
                //NLog: catch setup errors
                //logger.Error(exception, "Stopped program because of exception");
                throw;
            } finally {
                // Ensure to flush and stop internal timers/threads before application-exit (Avoid segmentation fault on Linux)
                NLog.LogManager.Shutdown ();
            }
        }

        public static IWebHost BuildWebHost (string[] args) =>
            WebHost.CreateDefaultBuilder (args)
            .UseStartup<Startup> ()
#if !DEBUG
            .UseUrls ("http://0.0.0.0:5000/")
#endif
            .UseStartup<Startup> ()
            .ConfigureLogging (logging => {
                logging.ClearProviders ();
                logging.SetMinimumLevel (Microsoft.Extensions.Logging.LogLevel.Trace);
            })
            .UseNLog () // NLog: Setup NLog for Dependency injection
            .Build ();
    }
}