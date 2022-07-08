using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61.Syntax_Sugar.Teacher_s_Decision
{
    class App
    {
        public static string FilterString(string str, char ch)
        {
            var i = 0;
            var result = "";
            while (i < str.Length)
            {
                var currentChar = str[i];
                if (currentChar != ch)
                {
                    result = result + currentChar;
                }

                i += 1;
            }

            return result;
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