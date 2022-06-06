using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30.Methods_And_Their_Call.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Hodor";

            var who = name.ToUpper();
            var what = name.ToLower();

            Console.WriteLine($"{who} says: \"{what}\"");
            Console.ReadKey();
        }
    }
}