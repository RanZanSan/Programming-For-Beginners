using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _63.Return_From_Cycles.Task
{
    class App
    {
        public static bool HasChar(string str, char ch)
        {
            var index = 0;

            while (index < str.Length)
            {
                if (str[index] == ch)
                    return true;

                index++;
            }

            return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(App.HasChar("Renly", 'R')); // true
            Console.WriteLine(App.HasChar("Renly", 'r')); // false
            Console.WriteLine(App.HasChar("Tommy", 'm')); // true
            Console.WriteLine(App.HasChar("Tommy", 'd')); // false
            Console.ReadKey();
        }
    }
}