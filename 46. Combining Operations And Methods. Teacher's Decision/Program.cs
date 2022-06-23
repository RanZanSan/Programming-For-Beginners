using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46.Combining_Operations_And_Methods.Teacher_s_Decision
{
    class App
    {
        public static bool IsInternationalPhone(string phone)
        {
            return phone[0] == '+';
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