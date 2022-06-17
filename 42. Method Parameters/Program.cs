using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42.Method_Parameters
{
    class App
    {
        public static char GetLastChar(string str)
        {
            // Вычисляем индекс последнего символа как длина строки - 1
            return str[str.Length - 1];
        }

        // Метод по нахождению среднего числа
        // Возвращаемый тип double,
        // так как в результате деления может получиться дробное число
        public static double Average(int x, int y)
        {
            return (x + y) / 2.0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Принимает на вход параметр любого типа
            Console.WriteLine("я параметр");

            // Принимает на вход два строковых параметра
            // первый - что ищем, второй - на что меняем
            Console.WriteLine("google".Replace("go", "mo")); // "moogle"

            // Принимает на вход два числовых параметра
            // первый - начальный индекс, второй - длина извлекаемой подстроки
            Console.WriteLine("hexlet".Substring(1, 3)); // "exl"
            Console.ReadKey();

            // Передача параметров напрямую без переменных
            Console.WriteLine(App.GetLastChar("Hexlet")); // 't'
            Console.WriteLine(App.GetLastChar("Goo")); // 'o'

            // Передача параметров через переменные
            var name1 = "Hexlet";
            Console.WriteLine(App.GetLastChar(name1)); // 't'
            var name2 = "Goo";
            Console.WriteLine(App.GetLastChar(name2)); // 'o'
            Console.ReadKey();

            // Точно таким же образом можно указывать два, три и более параметров. Каждый параметр отделяется от другого запятой.
            Console.WriteLine(App.Average(1, 5)); // 3.0
            Console.WriteLine(App.Average(1, 2)); // 1.5
            Console.ReadKey();
        }
    }
}