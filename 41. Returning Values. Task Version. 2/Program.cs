using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41.Returning_Values.Task_Version._2
{
    class App
    {
        public static int GetCurrentYear()
        {
            var data = DateTime.Now.Year;
            return data;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var year = App.GetCurrentYear();
            Console.WriteLine(year); // выведет текущий год
            Console.ReadKey();
        }
    }
}