using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Models
{
    class Circle : IShape
    {
        private string _color;

        public Circle(string color)
        {
            _color = color;
        }

        public string GetColor()
        {
            return _color;
        }

        public void Draw()
        {
            Console.WriteLine($"{_color} circle");
        }
    }
}
