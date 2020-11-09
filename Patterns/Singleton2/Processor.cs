using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton2
{
    class Processor
    {
        private int _start;
        public Processor(int start)
        {
            _start = start;
            ThreadSafeSingleton.GetInstance().Log("Processor створено.");
        }
        public int ProcessTo(int end)
        {
            int sum = 0;
            for (int i = _start; i <= end; ++i)
            {
                sum += i;
            }
            ThreadSafeSingleton.GetInstance().Log(
            "Processor обчислив деяке значення: " + sum);
            return sum;
        }
    }
}
