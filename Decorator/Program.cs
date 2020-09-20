using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new Logger();
            logger.Log("First message");

            var loggerDecorator = new LoggerDecorator(logger);
            loggerDecorator.Log("Second message");

            Console.ReadKey();
        }
    }
}
