using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    interface IVisitor
    {
        void VisitCar(Car car);
        void VisitTrack(Track track);
    }
}
