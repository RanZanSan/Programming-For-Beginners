using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50.Conditional_Construction__if_.Task
{
    class App
    {
        public static string GetSentenceTone(string word)
        {
            if (word == word.ToUpper())
                return "scream";

            return "normal";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(App.GetSentenceTone("Hello")); // "normal"
            Console.WriteLine(App.GetSentenceTone("WOW")); // "scream"
            Console.ReadKey();
        }
    }
}