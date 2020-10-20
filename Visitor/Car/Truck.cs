using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Track : Auto
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.VisitTrack(this);
        }
    }
}
