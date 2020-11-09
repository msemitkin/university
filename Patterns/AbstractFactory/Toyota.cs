using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //ConcreteProductA2
    public class Toyota : Car
    {
        public override void Info()
        {
            Console.WriteLine("Toyota");
        }
    }
}
