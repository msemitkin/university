using FactoryMethod;
using System;
namespace FactoryMethodExample
{
    class MainApp
    {
        static void Main()
        {
            Creator creator = new ConcreteCreator();
            for (int i = 1; i <= 3 ; i++)
            {
                var product = creator.FactoryMethod(i);
                Console.WriteLine("Where id = {0}, Created {1} ", i, product.GetType());
            }
            Console.ReadKey();
        }
    }
}

