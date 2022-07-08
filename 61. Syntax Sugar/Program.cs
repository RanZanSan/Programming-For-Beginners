using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61.Syntax_Sugar
{
    class App
    {
        public static string FilterString(string str, char ch)
        {
            var newStr = string.Empty;
            var index = 0;

            while (index < str.Length)
            {
                if (str[index] == ch)
                    newStr += "";
                else
                    newStr += str[index];

                index++;
            }

            return newStr;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var str = "If I look back I am lost";

            Console.WriteLine(App.FilterString(str, 'I')); // "f  look back  am lost"
            Console.WriteLine(App.FilterString(str, 'o')); // "If I lk back I am lst"
            Console.ReadKey();
        }
    }
}