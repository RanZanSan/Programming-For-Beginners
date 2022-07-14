using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _64.For_Cycle.Teacher_s_Decision
{
    class App
    {
        public static string Encrypt(string str)
        {
            var result = "";
            for (var i = 0; i < str.Length; i += 2)
            {
                if (i == str.Length - 1)
                {
                    result += str[i];
                }
                else
                {
                    var firstChar = str[i];
                    var secondChar = str[i + 1];
                    result = result + secondChar + firstChar;
                }
            }

            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(App.Encrypt("move")); // "omev"
            Console.WriteLine(App.Encrypt("attack")); // "taatkc"
            // Если число символов нечётное
            // то последний символ остается на своем месте
            Console.WriteLine(App.Encrypt("go!")); // "og!"
            Console.ReadKey();
        }
    }
}