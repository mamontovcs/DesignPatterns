using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new ObservableCollection<Auto>();
            collection.Add(new Car { ModelTitle = "ВАЗ" });
            collection.Add(new Track { ModelTitle = "ГАЗель" });
            collection.Add(new Car { ModelTitle = "Merсedes" });
            collection.Add(new Track { ModelTitle = "КамАЗ" });

            var visitor = new AutoVisitor();

            foreach (Auto a in collection)
            {
                a.Accept(visitor);
            }

            Console.ReadKey();
        }
    }
}
