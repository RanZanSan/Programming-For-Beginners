using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50.Conditional_Construction__if_
{
    public class App
    {
        public static string GetTypeOfSentence(string sentence)
        {
            if (sentence.EndsWith("?"))
            {
                return "question";
            }

            return "general";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(App.GetTypeOfSentence("Hodor")); // "general"
            Console.WriteLine(App.GetTypeOfSentence("Hodor?")); // "question"
            Console.ReadKey();
        }
    }
}