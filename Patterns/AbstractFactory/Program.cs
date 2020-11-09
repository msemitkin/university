using System;

namespace AbstractFactory
{
    class AbstractFactoryApp
    {
        static void Main(string[] args)
        {
            ICarFactory carFactory = new ToyotaFactory();
            ClientFactory client1 = new ClientFactory(carFactory);

            client1.Run();

            carFactory = new FordFactory();
            ClientFactory client2 = new ClientFactory(carFactory);
            client2.Run();

            carFactory = new MersedesFactory();
            ClientFactory client3 = new ClientFactory(carFactory);
            client3.Run();

            Console.ReadKey();
        }
    }
}
