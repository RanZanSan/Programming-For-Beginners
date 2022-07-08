using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56.Data_Aggregation__Numbers_.Task
{
    class App
    {
        public static int MultiplyNumbersFromRange(int start, int finish)
        {
            var multiply = 1;

            while (start <= finish)
            {
                multiply = multiply * start;
                start++;
            }

            return multiply;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(App.MultiplyNumbersFromRange(1, 5)); // 1 * 2 * 3 * 4 * 5 = 120
            Console.WriteLine(App.MultiplyNumbersFromRange(2, 3)); // 2 * 3 = 6
            Console.WriteLine(App.MultiplyNumbersFromRange(6, 6)); // 6
            Console.ReadKey();
        }
    }
}