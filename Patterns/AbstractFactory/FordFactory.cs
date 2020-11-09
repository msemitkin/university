using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    // ConcreteFactory1
    public class FordFactory : ICarFactory
    {
        // from CarFactory
        Car ICarFactory.CreateCar()
        {
            return new Ford();
        }

        Engine ICarFactory.CreateEngine()
        {
            return new FordEngine();
        }
    }
}
