using Flyweight.Models;

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
