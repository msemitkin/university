using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //ConcreteProductB2
    public class ToyotaEngine : Engine
    {
        public override void GetPower()
        {
            Console.WriteLine("Toyota Engine");
        }
    }
}
