using Flyweight.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; ++i)
            {
                Circle circle = (Circle)ShapeFactory.getCircle("Black");
                circle.Draw();
            }
        }
    }
}
