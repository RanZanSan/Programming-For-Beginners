using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _60.Forming_Strings_In_Loops.Teacher_s_Decision
{
    class App
    {
        public static string Reverse(string str)
        {
            var i = str.Length - 1;
            var result = "";
            while (i >= 0)
            {
                result = result + str[i];
                i = i - 1;
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