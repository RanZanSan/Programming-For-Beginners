using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _62.Increment_And_Decrement
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 0;
            Console.WriteLine(i++); // 0
            Console.WriteLine(i++); // 1
            Console.WriteLine(i--); // 2
            Console.WriteLine(i--); // 1
            Console.ReadKey();

            i = 0;
            Console.WriteLine(++i); // 1
            Console.WriteLine(++i); // 2
            Console.WriteLine(--i); // 1
            Console.WriteLine(--i); // 0
            Console.ReadKey();

            var x = 5;

            Console.WriteLine(++x); // => 6
            Console.WriteLine(x);   // => 6
            Console.WriteLine(x++); // => 6
            Console.WriteLine(x);   // => 7
            Console.ReadKey();
        }
    }
}