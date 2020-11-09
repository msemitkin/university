using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton2
{
    public class ThreadSafeSingleton
    {
        private ThreadSafeSingleton()
        {
            // Читаємо дані з деякого файлу і дістаємо номер останнього запису
            // _logCount = вичитане значення
        }
        private int _logCount = 0;
        private static ThreadSafeSingleton _loggerInstance;
        private static readonly object locker = new object();
        public static ThreadSafeSingleton GetInstance()
        {
            lock (locker)
            {
                if (_loggerInstance == null)
                {
                    _loggerInstance = new ThreadSafeSingleton();
                }
            }
            return _loggerInstance;
        }
        public void Log(String message)
        {
            Console.WriteLine(_logCount + ": " + message);
            _logCount++;
        }
    }
}
