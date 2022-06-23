using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46.Combining_Operations_And_Methods.Task
{
    class App
    {
        public static bool IsInternationalPhone(string phone)
        {
            return phone.First() == '+';
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(App.IsInternationalPhone("89602223423")); // false
            Console.WriteLine(App.IsInternationalPhone("+79602223423")); // true
            Console.ReadKey();
        }
    }
}