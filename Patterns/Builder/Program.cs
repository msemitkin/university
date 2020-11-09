using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        /** A customer ordering a pizza. */
        class BuilderExample
        {
            public static void Main(String[] args)
            {
                Waiter waiter = new Waiter();
                PizzaBuilder hawaiianPizzaBuilder = new HawaiianPizzaBuilder();
                PizzaBuilder spicyPizzaBuilder = new SpicyPizzaBuilder();
                PizzaBuilder margaritaPizzaBuilder = new MargaritaPizzaBuilder();
                waiter.SetPizzaBuilder(hawaiianPizzaBuilder);
                waiter.ConstructPizza();

                Pizza pizza = waiter.GetPizza();
                pizza.Info();

                Console.WriteLine();

                waiter.SetPizzaBuilder(spicyPizzaBuilder);
                waiter.ConstructPizza();
                
                pizza = waiter.GetPizza();
                pizza.Info();

                Console.WriteLine();
                
                waiter.SetPizzaBuilder(margaritaPizzaBuilder);
                waiter.ConstructPizza();
                pizza = waiter.GetPizza();
                pizza.Info();


                Console.ReadKey();
            }
        }

    }
}
