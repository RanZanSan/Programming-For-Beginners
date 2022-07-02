using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53.Ternary_Operator.Task.Version_2
{
    class Functions
    {
        public static string StringReverse(string word)
        {
            string newWord = string.Empty;

            for (int index = word.Length - 1; index >= 0; index--)
            {
                newWord = newWord + word[index];
            }

            return newWord;
        }
    }

    class App
    {
        public static string ConvertString(string word)
        {
            if (word.Length > 0)
                return char.IsUpper(word.First()) ? word : Functions.StringReverse(word);
            else
                return word;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(App.ConvertString("Hello")); // "Hello"
            Console.WriteLine(App.ConvertString("hello")); // "olleh"

            // Не забудьте учесть пустую строку!
            Console.WriteLine(App.ConvertString("")); // ""
            Console.ReadKey();
        }
    }
}