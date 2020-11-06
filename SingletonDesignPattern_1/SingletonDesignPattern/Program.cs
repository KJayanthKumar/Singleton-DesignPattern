using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    //Implementation example of first base version of singleton design pattern.
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(()=> EmployeeMethod(),() => StudentMethod());
            Console.ReadLine();
        }

        private static void StudentMethod()
        {
            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("From Student");
        }

        private static void EmployeeMethod()
        {
            Singleton fromEmployee = Singleton.GetInstance;
            fromEmployee.PrintDetails("From Employee");
        }
    }
}
