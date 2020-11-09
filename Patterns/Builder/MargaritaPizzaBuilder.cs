using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class MargaritaPizzaBuilder : PizzaBuilder
    {
        public override void BuildDough()
        {
            pizza.SetDough("margarita dough");
        }

        public override void BuildSauce()
        {
            pizza.SetSauce("margarita sauce");
        }

        public override void BuildTopping()
        {
            pizza.SetTopping("margarita topping");
        }
    }
}
