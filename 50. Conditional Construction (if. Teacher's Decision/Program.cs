using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50.Conditional_Construction__if.Teacher_s_Decision
{
    class App
    {
        public static string GetSentenceTone(string sentence)
        {
            if (sentence.ToUpper() == sentence)
            {
                return "scream";
            }

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