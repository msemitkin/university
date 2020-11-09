using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    // "Colleague"
    abstract class Colleague
    {
        protected Mediator mediator;

        // Constructor
        public Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }
        public abstract void Send(String message);
        public abstract void Notify(String message);
    }
}
