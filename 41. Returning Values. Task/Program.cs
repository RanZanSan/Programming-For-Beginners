using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41.Returning_Values.Task
{
    class App
    {
        public static int GetCurrentYear()
        {
            var data = DateTime.Now.ToString("yyyy-MM-dd");
            var year = data.Substring(0, data.IndexOf("-"));
            var number = Convert.ToInt32(year);

            return number;
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