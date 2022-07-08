using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57.Data_Aggregation__Strings_
{
    class App
    {
        public static string Repeat(string text, int times)
        {
            // Нейтральный элемент для строк – пустая строка
            var result = "";
            var i = 1;

            while (i <= times)
            {
                // Каждый раз добавляем строку к результату
                result = result + text;
                i = i + 1;
            }

            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(App.Repeat("hexlet", 3)); // "hexlethexlethexlet"
            Console.ReadKey();
        }
    }
}