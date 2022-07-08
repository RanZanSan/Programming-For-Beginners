using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57.Data_Aggregation__Strings_.Teacher_s_Decision
{
    class App
    {
        public static String JoinNumbersFromRange(int start, int finish)
        {
            var i = start;
            var result = "";

            while (i <= finish)
            {
                result = result + i;
                i = i + 1;
            }

            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(App.JoinNumbersFromRange(1, 1)); // "1"
            Console.WriteLine(App.JoinNumbersFromRange(2, 3)); // "23"
            Console.WriteLine(App.JoinNumbersFromRange(5, 10)); // "5678910"
            Console.ReadKey();
        }
    }
}