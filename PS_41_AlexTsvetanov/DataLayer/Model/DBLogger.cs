using DataLayer.Database;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Model
{
    public class DBLogger : ILogger
    {
        public class LogMessage
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }
            public required string Text { get; set; }
            public required LogLevel Level { get; set; }
        }
        private readonly DatabaseContext _context;
        DBLogger(DatabaseContext context)
        {
            context.Database.EnsureCreated();
            _context = context;
        }
        public IDisposable? BeginScope<TState>(TState state) where TState : notnull
        {
            throw new NotImplementedException();
        }
        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }
        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
            var text = formatter(state, exception);
            _context.Add<LogMessage>(new LogMessage
            {
                Text = text,
                Level = logLevel,
            });
        }
    }
}
