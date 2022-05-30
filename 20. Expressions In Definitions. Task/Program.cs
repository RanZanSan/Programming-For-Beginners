using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Expressions_In_Definitions.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Считаем, что:
             * 1 евро = 1.25 долларов
             * 1 доллар = 60 рублей
             */

            var oneEuros = 1.25; // долларов
            var oneDollars = 60; // рублей
            var eurosCount = 100;

            var dollarsCount = eurosCount * oneEuros;
            var rublesCount = dollarsCount * oneDollars;

            Console.WriteLine(dollarsCount + "\n" + rublesCount);
            Console.ReadKey();
        }
    }
}