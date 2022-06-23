using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49.Logical_Operators_2
{
    class App
    {
        public static bool IsLeapYear(int year)
        {
            return year % 400 == 0 || (year % 4 == 0 && year % 100 != 0);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(App.IsLeapYear(2018)); // false
            Console.WriteLine(App.IsLeapYear(2017)); // false
            Console.WriteLine(App.IsLeapYear(2016)); // true
            Console.ReadKey();
        }
    }
}