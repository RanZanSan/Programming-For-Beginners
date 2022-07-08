using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57.Data_Aggregation__Strings_.Task
{
    class App
    {
        public static string JoinNumbersFromRange(int start, int finish)
        {
            var result = string.Empty;

            while(start <= finish)
            {
                result = result + start.ToString();
                start++;
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