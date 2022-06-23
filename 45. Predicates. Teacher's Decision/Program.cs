using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45.Predicates.Teacher_s_Decision
{
    public class App
    {
        public static bool IsMister(string greeting)
        {
            return greeting == "Mister";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(App.IsMister("Mister")); // true
            Console.WriteLine(App.IsMister("Miss")); // false
            Console.ReadKey();
        }
    }
}