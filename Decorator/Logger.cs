using System;

namespace Decorator
{
    internal class Logger : ILogger
    {
        public Logger()
        {

        }

        public void Log(string message)
        {
            Console.WriteLine(message + " | " + DateTime.Now );
        }
    }
}
