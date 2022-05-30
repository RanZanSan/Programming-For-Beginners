using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Задание
 * Выведите на экран строку Do you want to eat, <name>?, где вместо <name> должна использоваться константа stark.
 * Вывод должен получиться таким:
 */

namespace _24.Interpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            var stark = "Arya";

            Console.WriteLine($"Do you want to eat, {stark}?");
            Console.ReadKey();
        }
    }
}