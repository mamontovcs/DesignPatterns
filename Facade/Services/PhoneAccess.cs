using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Services
{
    class PhoneAccess : IPhoneAccess
    {
        private IUnlockService _unlockService;

        public PhoneAccess(IUnlockService unlockService)
        {
            _unlockService = unlockService;
        }

        public bool UnlockPhone(string fingerCode)
        {
            var checkResult = _unlockService.CheckFingerPrintCode(fingerCode);

            if (!checkResult)
            {
                return false;
            }

            _unlockService.CheckInterface();
            var updateMessage = _unlockService.CheckUpdates();

            if (!string.IsNullOrEmpty(updateMessage))
            {
                Console.WriteLine(updateMessage);
            }

            return true;
        }
    }
}
