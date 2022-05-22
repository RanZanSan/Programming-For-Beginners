using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Operation_Priority
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(3 * (4 - 2)); // => 6
            Console.WriteLine(7 * 3 + (4 / 2) - (8 + (2 - 1))); // => 14
            Console.ReadKey();

            // Было:
            Console.WriteLine(8 / 2 + 5 - -3 / 2); // => 10
            // Стало:
            Console.WriteLine(((8 / 2) + 5) - (-3 / 2)); // => 10
            Console.ReadKey();
        }
    }
}