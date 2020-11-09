using System;
using System.Collections;
using System.Text;

namespace Mediator.Examples
{
    // Mainapp test application
    class MainApp
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            ConcreteMediator m = new ConcreteMediator();
            ConcreteColleague1 c1 = new ConcreteColleague1(m);
            ConcreteColleague2 c2 = new ConcreteColleague2(m);
            ConcreteColleague3 c3 = new ConcreteColleague3(m);
            m.Colleague1 = c1;
            m.Colleague2 = c2;
            m.Colleague3 = c3;
            m.Send("How are you?", c1);
            m.Send("Fine, thanks", c2);
            m.Send("Hello!!!", c3);

            // Wait for user
            Console.Read();
        }
    }
}
