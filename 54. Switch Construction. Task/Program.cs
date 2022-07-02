using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54.Switch_Construction.Task
{
    class App
    {
        public static string GetNumberExplanation(int number)
        {
            switch (number)
            {
                case 666:
                    return "devil number";
                case 42:
                    return "answer for everything";
                case 7:
                    return "prime number";
                default:
                    return null;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(App.GetNumberExplanation(8)); // null

            // Объяснения есть только для указанных ниже чисел
            Console.WriteLine(App.GetNumberExplanation(666)); // "devil number"
            Console.WriteLine(App.GetNumberExplanation(42));  // "answer for everything"
            Console.WriteLine(App.GetNumberExplanation(7));   // "prime number"
            
            Console.ReadKey();
        }
    }
}