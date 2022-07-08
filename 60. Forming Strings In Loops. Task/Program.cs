using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _60.Forming_Strings_In_Loops.Task
{
    class App
    {
        public static string Reverse(string str)
        {
            var result = string.Empty;
            var length = str.Length - 1;

            while (length >= 0)
            {
                result = result + str[length];
                length--;
            }

            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(App.Reverse("Bran"));
            Console.WriteLine(App.Reverse(""));
            Console.WriteLine(App.Reverse("Hexlet"));
            Console.ReadKey();
        }
    }
}