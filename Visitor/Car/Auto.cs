using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    abstract class Auto
    {
        public string ModelTitle { get; set; }
        public abstract void Accept(IVisitor visitor);
    }
}
