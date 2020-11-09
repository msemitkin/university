using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /** "Director" */
    class Waiter
    {
        private PizzaBuilder pizzaBuilder;
        public void SetPizzaBuilder(PizzaBuilder pb) { pizzaBuilder = pb; }
        public Pizza GetPizza() { return pizzaBuilder.GetPizza(); }
        public void ConstructPizza()
        {
            pizzaBuilder.CreateNewPizza();
            pizzaBuilder.BuildDough();
            pizzaBuilder.BuildSauce();
            pizzaBuilder.BuildTopping();
        }
    }
}
