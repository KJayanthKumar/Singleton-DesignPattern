using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    //Implementation example of first base version of singleton design pattern.
    public sealed class Singleton
    {
        private static int counter = 0;
        private static Singleton instance = null;
        private static readonly object obj = new object(); 

        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value: " + counter.ToString());
        }
        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (obj)
                    {
                        if (instance == null)
                            instance = new Singleton();
                    }
                }
                return instance;
            }
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }

    }
}
