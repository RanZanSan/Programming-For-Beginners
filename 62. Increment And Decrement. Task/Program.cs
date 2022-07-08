using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _62.Increment_And_Decrement.Task
{
    class App
    {
        public static string MakeItFunny(string str, int n)
        {
            var index = 0;
            var newStr = string.Empty;

            while (index < str.Length)
            {
                if ((index + 1) % n == 0)
                    newStr += char.ToUpper(str[index]);
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
            var text = "I never look back";
            // Каждый третий элемент

            Console.WriteLine(App.MakeItFunny(text, 3)); // "I NevEr LooK bAck"
            Console.ReadKey();
        }
    }
}