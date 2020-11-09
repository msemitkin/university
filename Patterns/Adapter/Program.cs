using Adapter;
using System;
namespace AdapterExample
{
    public class AdapterDemo
    {
        static void Main()
        {
            // 1) Ми можемо користуватися новою системою без проблем
            var newElectricitySystem = new NewElectricitySystem();
            ElectricityConsumer.ChargeNotebook(newElectricitySystem);
            // 2) Ми повинні адаптуватися до старої системи, використовуючи адаптер
            var oldElectricitySystem = new OldElectricitySystem();
            var adapter = new AdapterClass(oldElectricitySystem);
            ElectricityConsumer.ChargeNotebook(adapter);
            Console.ReadKey();
        }
    }
}
