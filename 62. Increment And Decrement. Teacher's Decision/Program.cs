using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _62.Increment_And_Decrement.Teacher_s_Decision
{
    class App
    {
        public static string MakeItFunny(string str, int n)
        {
            var i = 0;
            var result = "";
            while (i < str.Length)
            {
                var current = str[i];
                if ((i + 1) % n == 0)
                {
                    result = result + char.ToUpper(current);
                }
                else
                {
                    result = result + current;
                }

                i++;
            }

            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var text = "I never look back";
            // Каждый третий элемент

            Console.WriteLine(App.MakeItFunny(text, 3)); // "I NevEr LooK bAck"
            Console.ReadKey();
        }
    }
}