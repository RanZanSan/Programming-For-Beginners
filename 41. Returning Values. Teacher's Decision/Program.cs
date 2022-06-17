using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41.Returning_Values.Teacher_s_Decision
{
    class App
    {
        public static int GetCurrentYear()
        {
            var currentDate = DateTime.Now.ToString("yyyy-MM-dd");
            var currentYearAsString = currentDate.Substring(0, 4);
            var currentYear = Convert.ToInt32(currentYearAsString);
            return currentYear;
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