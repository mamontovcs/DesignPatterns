using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Car : Auto
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.VisitCar(this);
        }
    }
}
