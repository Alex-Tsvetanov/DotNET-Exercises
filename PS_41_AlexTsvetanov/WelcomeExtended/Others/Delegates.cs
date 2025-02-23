using Microsoft.Extensions.Logging;
using System.IO;
using WelcomeExtended.Helpers;

namespace WelcomeExtended.Others
{
    public class Delegates
    {
        public static readonly ILogger logger = LoggerHelper.GetLogger("Hello", Console.Out);
        public static readonly StreamWriter file = new(@"log.txt");
        public static readonly ILogger logger2 = LoggerHelper.GetLogger("Hello", file);
        public static void Log(string error)
        {
            logger.LogError(error);
            logger2.LogError(error);
        }
        public static void Log2(string error)
        {
            Console.WriteLine("- DELEGATES -");
            Console.WriteLine($"{error}");
            Console.WriteLine("- DELEGATES -");
        }
    }
}
