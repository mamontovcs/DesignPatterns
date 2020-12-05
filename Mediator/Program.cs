using Mediator.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            var mediator = new ColleagueMediator();

            var developer = new Developer(mediator);
            var tester = new Tester(mediator);

            mediator.Developer = developer;
            mediator.Tester = tester;

            developer.Send("Баг пофиксили. Можешь тестировать.");
            tester.Send("Баг закрыла. Спасибо.");

            Console.Read();
        }
    }
}
