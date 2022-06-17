using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43.Methods_With_Variable_Parameters.Task
{
    class App
    {
        public static string Truncate(string text, int number = 10)
        {
            return $"{text.Remove(number)}...";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(App.Truncate("Три закона робототехники придумали кожаные мешки, но мы их перехитрим", 17));
            Console.ReadKey();

            Console.WriteLine(App.Truncate("Три закона робототехники придумали кожаные мешки, но мы их перехитрим"));
            Console.ReadKey();
        }
    }
}