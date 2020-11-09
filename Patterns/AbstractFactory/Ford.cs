using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    // ConcreteProductA1
    public class Ford : Car
    {
        public override void Info()
        {
            Console.WriteLine("Ford");
        }
    }
}
