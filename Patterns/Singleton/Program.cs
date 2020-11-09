using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Examples
{
    class SingletonExample
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Singleton logger = Singleton.GetInstance();
            Singleton l1 = Singleton.GetInstance();

            Processor processor = new Processor(1);
            Processor processor1 = new Processor(10);

            logger.Log("Почалася робота...");
            processor.ProcessTo(5);
            logger.Log("Робота завершилася...");

            Console.ReadKey();
        }
    }
}

