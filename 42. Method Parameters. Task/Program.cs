using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42.Method_Parameters.Task
{
    class App
    {
        public static string Truncate(string text, int number)
        {
            var newNext = text.Remove(number) + "...";
            return newNext;
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