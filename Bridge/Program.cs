using Bridge.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            var tv = new TV();

            var remoteControl = new RemoteControl(tv);

            for (int i = 0; i < 5; i++)
            {
                remoteControl.IncreaseVolume();
            }

            Console.WriteLine("Volume: " + tv.Volume);
                
            for (int i = 0; i < 2; i++)
            {
                remoteControl.DecreaseVolume();
            }

            Console.WriteLine("Volume: " + tv.Volume);


            Console.ReadKey();
        }
    }
}
