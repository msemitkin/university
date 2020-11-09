using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class ConcreteCreator : Creator
    {
        public override Product FactoryMethod(int type)
        {
            switch (type)
            {
                case 1: return new ConcreteProductA();
                case 2: return new ConcreteProductB();
                case 3: return new ConcreteProductC();
                default: throw new ArgumentException("Invalid type.", "type");
            }
        }
    }
}
