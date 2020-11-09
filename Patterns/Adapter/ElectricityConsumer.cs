using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class ElectricityConsumer
    {
        // Зарядний пристрій, який розуміє тільки нову систему
        public static void ChargeNotebook(INewElectricitySystem electricitySystem)
        {
            Console.WriteLine(electricitySystem.MatchWideSocket());
        }
    }
}
