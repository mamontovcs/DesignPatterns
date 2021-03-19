using System;

namespace Chain_of_Responsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setup Chain of Responsibility
            Approver larry = new Director();
            Approver sam = new VicePresident();
            Approver tammy = new President();

            larry.SetSuccessor(sam);
            sam.SetSuccessor(tammy);

            // Generate and process purchase requests
            Purchase purchase = new Purchase(2034, 350.00, "Assets");

            larry.ProcessRequest(purchase);

            purchase = new Purchase(2035, 32590.10, "Project X");

            larry.ProcessRequest(purchase);

            purchase = new Purchase(2036, 122100.00, "Project Y");

            larry.ProcessRequest(purchase);

            // Wait for user

            Console.ReadKey();
        }
    }
    
}
