using System;

namespace Chain_of_Responsibility
{
    /// <summary>
    /// The 'ConcreteHandler' class
    /// </summary>
    internal class Director : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 10000.0)
            {
                Console.WriteLine("{0} approved request# {1}",
                GetType().Name, purchase.Number);
            }
            else
            {
                Successor?.ProcessRequest(purchase);
            }
        }

    }
}
