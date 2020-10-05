using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    interface IUnlockService
    {
        bool CheckFingerPrintCode(string code);

        bool CheckInterface();

        string CheckUpdates();
    }
}
