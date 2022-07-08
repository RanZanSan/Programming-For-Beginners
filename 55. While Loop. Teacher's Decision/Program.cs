using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55.While_Loop.Teacher_s_Decision
{
    class App
    {
        public static void PrintNumbers(int firstNumber)
        {
            var i = firstNumber;
            while (i >= 1)
            {
                Console.WriteLine(i);
                i = i - 1;
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