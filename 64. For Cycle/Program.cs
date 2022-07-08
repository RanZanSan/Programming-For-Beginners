using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _64.For_Cycle
{
    class App
    {
        public static string ReverseString(string str)
        {
            var result = "";
            for (var i = 0; i < str.Length; i++)
            {
                result = str[i] + result;
            }

            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(App.ReverseString("Hexlet"));
            Console.ReadKey();
        }
    }
}