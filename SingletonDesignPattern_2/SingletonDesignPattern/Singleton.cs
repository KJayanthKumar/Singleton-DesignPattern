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
        private static readonly Lazy <Singleton> instance = new Lazy<Singleton>(()=>new Singleton());
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value: " + counter.ToString());
        }
        public static Singleton GetInstance
        {
            get
            {
                return instance.Value;
            }
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }

    }
}
