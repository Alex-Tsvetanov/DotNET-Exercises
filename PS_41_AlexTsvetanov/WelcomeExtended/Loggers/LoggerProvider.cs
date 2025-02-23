using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeExtended.Loggers
{
    class LoggerProvider : ILoggerProvider
    {
        private TextWriter _output;

        public LoggerProvider(System.IO.TextWriter output)
        {
            _output = output;
        }
        public ILogger CreateLogger(string categoryName)
        {
            return new HashLogger(categoryName, _output);
        }

        public void Dispose()
        {
            _output.Close();
        }
    }
}
