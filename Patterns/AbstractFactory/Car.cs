using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    // AbstractProductA
    public abstract class Car
    {
        public abstract void Info();
        public void Interact(Engine engine)
        {
            Info();
            Console.WriteLine("Set Engine: ");
            engine.GetPower();
        }
    }
}
