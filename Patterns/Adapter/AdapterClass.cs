using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    // Адаптер назовні виглядає як нові євророзетки, шляхом наслідування прийнятного у 
    // системі інтерфейсу
    class AdapterClass : INewElectricitySystem
    {
        // Але всередині він старий
        private readonly OldElectricitySystem _adaptee;
        public AdapterClass(OldElectricitySystem adaptee)
        {
            _adaptee = adaptee;
        }

        // А тут відбувається вся магія: наш адаптер «перекладає»
        // функціональність із нового стандарту на старий
        public string MatchWideSocket()
        {
            // Якщо б була різниця 
            // то тут ми б помістили трансформатор
            return _adaptee.MatchThinSocket();
        }
    }
}
