using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.GetInstance().WriteTrace("Hello World!");
            Logger.GetInstance().WriteTrace("Hello New World!");
            Console.ReadLine();
        }
    }

    class Logger
    {
        private static Logger logger;
        private static object lockObject = new object();
        private Logger()
        {

        }

        public static Logger GetInstance()
        {
            lock (lockObject)
            {
                if (logger == null)
                    logger = new Logger();
                return logger;
            }
        }

        public void WriteTrace(string message)
        {
            Console.WriteLine("{0}", message);
        }
    }
}
