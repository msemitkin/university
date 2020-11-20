using System;

namespace Solid2
{
    class ConsoleLogger : ILogger
    {
        private static ConsoleLogger instance = null;
        private ConsoleLogger() { }
        public static ILogger GetInstance()
        {
            if (instance == null)
            {
                instance = new ConsoleLogger();
            }
            return instance;
        }
        public void log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
