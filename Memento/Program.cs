using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneService phone = new PhoneService();
            phone.State = "Airplane mode";

            ModeRepository modeRepository = new ModeRepository();
            modeRepository.Memento = phone.CreateMemento();

            phone.State = "Regular mode";

            phone.SetMemento(modeRepository.Memento);

            Console.ReadKey();
        }
    }
}
