using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    // ConcreteProductB1
    public class FordEngine : Engine
    {
        public override void GetPower()
        {
            Console.WriteLine("Ford Engine");
        }
    }
}
