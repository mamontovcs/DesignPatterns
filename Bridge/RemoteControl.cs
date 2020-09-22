using Bridge.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class RemoteControl : IRemoteControl
    {
        private Device device;

        public RemoteControl(Device device)
        {
            this.device = device;
        }

        public void DecreaseVolume()
        {
            var volume = --device.Volume;

            device.SetVolume(volume);
        }

        public void IncreaseVolume()
        {
            var volume = ++device.Volume;
            device.SetVolume(volume);
        }
    }
}
