using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55.While_Loop.Task
{
    class App
    {
        public static void PrintNumbers(int firstNumber)
        {
            while (firstNumber > 0)
            {
                Console.WriteLine(firstNumber);
                firstNumber--;
            }

            Console.WriteLine("finished!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            App.PrintNumbers(4);
            Console.ReadKey();
        }
    }
}