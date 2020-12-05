using Mediator.Entity;

namespace Mediator
{
    class ColleagueMediator : Mediator
    {
        public Colleague Developer { get; set; }
        public Colleague Tester { get; set; }

        public override void Send(string msg, Colleague colleague)
        {
            if (Developer == colleague)
                Tester.Notify(msg);
            else
                Developer.Notify(msg);
        }
    }
}
