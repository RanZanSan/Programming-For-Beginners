using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58.Traversing_strings.Task
{
    class App
    {
        public static void PrintReversedNameBySymbol(string name)
        {
            var index = name.Length - 1;

            while (index >= 0)
            {
                Console.WriteLine(name[index]);
                index--;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var name = "Arya";
            App.PrintReversedNameBySymbol(name);
            // 'a'
            // 'y'
            // 'r'
            // 'A'

            Console.ReadKey();
        }
    }
}