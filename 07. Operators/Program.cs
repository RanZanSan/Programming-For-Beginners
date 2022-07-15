using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(8 + 2); // В этом примере + это оператор, а числа 8 и 2 — это операнды.
            Console.ReadKey();

            Console.WriteLine(-3); // => -3
            /*
             * Выше пример применения унарной операции к числу 3. Оператор минус перед тройкой говорит компилятору взять число 3 и найти противоположное, то есть -3.
             * Это немного может сбить с толку, потому что -3 — это одновременно и число само по себе, и оператор с операндом, но у языков программирования такая структура.
             */
            Console.ReadKey();
        }
    }
}