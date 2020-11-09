using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Singleton
    {
        private Singleton() { }
        private int _logCount = 0;
        private static Singleton _singletonInstance = null;
        public static Singleton GetInstance()
        {
            if (_singletonInstance == null)
            {
                _singletonInstance = new Singleton();

            }
            return _singletonInstance;
        }
        public void Log(String message)
        {
            Console.WriteLine(_logCount + ": " + message);
            _logCount++;
        }
    }
}
