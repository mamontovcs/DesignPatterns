using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Entity
{
    abstract class Device
    {
        internal abstract int Volume { get; set; }

        internal abstract void SetVolume(int volume);
    }
}
