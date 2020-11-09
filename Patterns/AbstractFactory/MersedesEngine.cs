using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class MersedesEngine : Engine
    {
        public override void GetPower()
        {
            Console.WriteLine("Mersedes Engine");
        }
    }
}
