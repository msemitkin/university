using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    // Широковикористовуваний інтерфейс нової системи (специфікація до квартири)
    interface INewElectricitySystem
    {
        string MatchWideSocket();
    }
}
