using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class MersedesFactory : ICarFactory
    {
        public Car CreateCar()
        {
            return new Mersedes();
        }

        public Engine CreateEngine()
        {
            return new MersedesEngine();
        }
    }
}
