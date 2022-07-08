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

            for (int index = 0; index < str.Length; index++)
            {}

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