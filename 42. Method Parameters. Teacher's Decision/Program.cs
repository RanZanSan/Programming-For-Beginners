using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42.Method_Parameters.Teacher_s_Decision
{
    class App
    {
        public static string Truncate(string str, int count)
        {
            return $"{str.Substring(0, count)}...";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int number = Convert.ToInt32(Console.ReadLine());

            string result = App.Truncate(text, number);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}