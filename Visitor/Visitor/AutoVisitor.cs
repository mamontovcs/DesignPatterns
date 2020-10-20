using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class AutoVisitor : IVisitor
    {
        public void VisitCar(Car car)
        {
            Console.WriteLine($"Легковой автомобиль модели: {car.ModelTitle}");
        }
        public void VisitTrack(Track track)
        {
            Console.WriteLine($"Грузовой автомобиль модели: {track.ModelTitle}");
        }
    }
}
