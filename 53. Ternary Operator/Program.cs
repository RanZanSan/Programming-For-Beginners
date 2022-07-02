using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53.Ternary_Operator
{
    // Посмотрите на определение метода, который возвращает модуль переданного числа:
    class App
    {
        // Если больше 0 то возвращаем число как есть, если меньше, то убираем знак
        public static int Abs(int number)
        {
            if (number >= 0)
            {
                return number;
            }

            return -number;
        }

        // Наш пример выше с тернарным оператором превращается в три строки кода:
        public static int TernaryOperatorExample(int number)
        {
            return number >= 0 ? number : -number;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(App.Abs(10)); // 10
            Console.WriteLine(App.Abs(-10)); // 10
            Console.ReadKey();

            Console.WriteLine(App.TernaryOperatorExample(10)); // 10
            Console.WriteLine(App.TernaryOperatorExample(-10)); // 10
            Console.ReadKey();
        }
    }
}