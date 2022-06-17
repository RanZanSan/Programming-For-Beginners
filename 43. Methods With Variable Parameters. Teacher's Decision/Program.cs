using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43.Methods_With_Variable_Parameters.Teacher_s_Decision
{
    class App
    {
        public static string Truncate(string str, int count = 10)
        {
            return $"{str.Substring(0, count)}...";
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