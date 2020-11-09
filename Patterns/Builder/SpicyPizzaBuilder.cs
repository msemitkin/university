using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    //Concrete Builder
    class SpicyPizzaBuilder : PizzaBuilder
    {
        public override void BuildDough() { pizza.SetDough("pan baked"); }
        public override void BuildSauce() { pizza.SetSauce("hot"); }
        public override void BuildTopping() { pizza.SetTopping("pepparoni+salami"); }
    }
}
