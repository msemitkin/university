using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    // Система яку будемо адаптовувати
    class OldElectricitySystem
    {
        public string MatchThinSocket()
        {
            return "old system";
        }
    }
}
