using Flyweight.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class ShapeFactory
    {
        private static List<Circle> _circles = new List<Circle>() /*{ new Circle("Black")}*/;

        public static IShape getCircle(string color)
        {
            Circle circle = _circles.Find(x => x.GetColor() == color);

            if (circle == null)
            {
                circle = new Circle(color);
                _circles.Add(circle);
                Console.WriteLine("Creating circle of color : " + color);
            }
            return circle;
        }
    }
}
