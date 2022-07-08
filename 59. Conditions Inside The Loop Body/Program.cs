using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _59.Conditions_Inside_The_Loop_Body
{
    class App
    {
        public static int CountChars(string str, char ch)
        {
            var i = 0;
            var count = 0;
            while (i < str.Length)
            {
                if (str[i] == ch)
                {
                    // Считаем только подходящие символы
                    count = count + 1;
                }

                // Счетчик увеличивается в любом случае
                i = i + 1;
            }

            return count;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(App.CountChars("Fear cuts deeper than swords.", 'e')); // 4
            // Если вы ничего не нашли, то результат — 0 совпадений
            Console.WriteLine(App.CountChars("Sansa", 'y')); // 0
            Console.ReadKey();
        }
    }
}