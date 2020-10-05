using System;
using System.Collections.Generic;

namespace Facade.Services
{
    class UnlockService : IUnlockService
    {
        public bool CheckFingerPrintCode(string code)
        {
            var fingers = new List<string>() { "73074brbaccpauraiuofacfb", "3be732cbrtw7fyewc", "yiuyhjb324wsfds" };

            if (fingers.Contains(code))
            {
                return true;
            }

            return false;
        }

        public bool CheckInterface()
        {
            Console.WriteLine("Interface was checked. Everything is OK.");
            return true;
        }

        public string CheckUpdates()
        {
            return "You can update to IOS 15";
        }
    }
}
