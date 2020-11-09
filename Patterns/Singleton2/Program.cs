using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            ThreadSafeSingleton logger = ThreadSafeSingleton.GetInstance();
            Processor processor = new Processor(1);
            logger.Log("Почалася робота...");
            processor.ProcessTo(5);
            logger.Log("Робота завершилася...");

            Console.ReadKey();
        }
    }
}
