using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    // ConcreteFactory2
    public class ToyotaFactory : ICarFactory
    {
        // from CarFactory
        Car ICarFactory.CreateCar()
        {
            return new Toyota();
        }

        Engine ICarFactory.CreateEngine()
        {
            return new ToyotaEngine();
        }
    }
}
