using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _64.For_Cycle.Task
{
    class App
    {
        public static string Encrypt(string str)
        {
            var result = string.Empty;

            if (str.Length % 2 == 0)
            {
                for (int index = 0; index < str.Length; index++)
                {
                    if (index % 2 == 0)
                        result += str[index + 1];
                    else
                        result += str[index - 1];
                }
            }
            else
            {
                for (int index = 0; index < str.Length - 1; index++)
                {
                    if (index % 2 == 0)
                        result += str[index + 1];
                    else
                        result += str[index - 1];
                }

                result += str.Last();
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