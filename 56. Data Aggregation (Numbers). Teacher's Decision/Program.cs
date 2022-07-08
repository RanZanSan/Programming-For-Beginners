using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56.Data_Aggregation__Numbers_.Teacher_s_Decision
{
    class App
    {
        public static int MultiplyNumbersFromRange(int start, int finish)
        {
            var i = start;
            var result = 1;

            while (i <= finish)
            {
                result = result * i;
                i = i + 1;
            }

            return result;
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