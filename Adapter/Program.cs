using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new MessageService();
            service.Publish("Message from original service");


            var adapter = new MessageServiceAdapter(service);
            var resultOfAdapting = adapter.Publish("Message from adapted service");

            Console.WriteLine(resultOfAdapting);

            Console.ReadKey();
        }
    }
}
