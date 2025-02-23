using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WelcomeExtended.Loggers;

namespace WelcomeExtended.Helpers
{
    static class LoggerHelper
    {
        public static ILogger GetLogger(string categoryName, System.IO.TextWriter output)
        {
            var loggerFactory = new LoggerFactory();
            loggerFactory.AddProvider(new LoggerProvider(output));

            return loggerFactory.CreateLogger(categoryName);
        }
    }
}
