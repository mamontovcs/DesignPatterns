using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facade.Services;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var unlockService = new UnlockService();
            var phoneAccess = new PhoneAccess(unlockService);

            phoneAccess.UnlockPhone("73074brbaccpauraiuofacfb");

            Console.ReadKey();
        }
    }
}
