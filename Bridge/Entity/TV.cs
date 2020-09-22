using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Entity
{
    class TV : Device
    {
        private int _volume;

        internal override int Volume { get => _volume; set { _volume = value; } }

        internal override void SetVolume(int volume)
        {
            Volume = volume;
        }
    }
}
