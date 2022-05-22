using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Composition_Of_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(3 + 5 - 2); // 3 + 5 - 2 => 8 - 2 => 6
            Console.ReadKey();

            Console.WriteLine(2 * 4 * 5 * 10); // 2 * 4 * 5 * 10 => 8 * 5 * 10 => 40 * 10 => 400
            Console.ReadKey();
        }
    }
}