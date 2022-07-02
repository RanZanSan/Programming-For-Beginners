using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52.else_if_Construct
{
    class App
    {
        public static string GetTypeOfSentence(string sentence)
        {
            var sentenceType = "";

            if (sentence.EndsWith("?"))
            {
                sentenceType = "question";
            }
            else if (sentence.EndsWith("!"))
            {
                sentenceType = "exclamation";
            }
            else
            {
                sentenceType = "general";
            }

            return "Sentence is " + sentenceType;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*
             * В самой полной версии, конструкция if содержит не только ветку else, но и другие условные проверки с помощью else if.
             * Такой вариант используется при большом количестве проверок, которые взаимоисключают друг друга.
             * 
             * if (что-то)
             * {
             * 
             * }
             * else if (другая проверка)
             * {
             * 
             * }
             * else if (другая проверка)
             * {
             * 
             * }
             * else
             * {
             * 
             * }
             */

            Console.WriteLine(App.GetTypeOfSentence("Who?")); // "Sentence is question"
            Console.WriteLine(App.GetTypeOfSentence("No")); // "Sentence is general"
            Console.WriteLine(App.GetTypeOfSentence("No!")); // "Sentence is exclamation"
            Console.ReadKey();
        }
    }
}