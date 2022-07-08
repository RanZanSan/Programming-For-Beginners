using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _59.Conditions_Inside_The_Loop_Body.Task
{
    class App
    {
        public static int CountChars(string str, char ch)
        {
            var i = 0;
            var count = 0;

            while (i < str.Length)
            {
                if (char.ToLower(str[i]) == char.ToLower(ch))
                    count = count + 1;

                i = i + 1;
            }

            return count;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(App.CountChars("HexlEt", 'e')); // 2
            Console.WriteLine(App.CountChars("HexlEt", 'E')); // 2
            Console.ReadKey();
        }
    }
}