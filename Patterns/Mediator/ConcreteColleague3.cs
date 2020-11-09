using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class ConcreteColleague3 : Colleague
    {
        public ConcreteColleague3(Mediator mediator) : base(mediator) { }

        public override void Notify(string message)
        {
            Console.WriteLine("Colleague3 gets message: " + message);
        }

        public override void Send(string message)
        {
            mediator.Send(message, this);
        }
    }
}
