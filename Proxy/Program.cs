using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            var server = new ServerProxy();

            Console.WriteLine(server.GETRequest());

            Console.ReadKey();
        }
    }
}
