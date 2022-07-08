using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58.Traversing_strings
{
    class App
    {
        public static void PrintNameBySymbol(string name)
        {
            var i = 0;
            // Такая проверка будет выполняться до конца строки
            // включая последний символ. Его индекс `name.Length - 1`.
            while (i < name.Length)
            {
                // Обращаемся к символу по индексу
                Console.WriteLine(name[i]);
                i = i + 1;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var name = "Arya";
            App.PrintNameBySymbol(name);
            // 'A'
            // 'r'
            // 'y'
            // 'a'

            Console.ReadKey();
        }
    }
}