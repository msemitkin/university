using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    //Abstract Builder
    abstract class PizzaBuilder
    {
        protected Pizza pizza;
        public PizzaBuilder() { }
        public Pizza GetPizza() { return pizza; }
        public void CreateNewPizza() { pizza = new Pizza(); }

        public abstract void BuildDough();
        public abstract void BuildSauce();
        public abstract void BuildTopping();
    }
}
