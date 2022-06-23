using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Оператор % вычисляет остаток от деления (не путайте с делением):
 * 7 % 2 → 1
 * 21 % 3 → 0
 * 19 % 5 → 4
 */

namespace _46.Combining_Operations_And_Methods
{
    class App
    {
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(App.IsEven(10)); // true
            Console.WriteLine(App.IsEven(3)); // false
            Console.ReadKey();
        }
    }
}