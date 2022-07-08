using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56.Data_Aggregation__Numbers_
{
    class App
    {
        public static int SumNumbersFromRange(int start, int finish)
        {
            // Технически можно менять start
            // Но входные аргументы нужно оставлять в исходном значении
            // Это сделает код проще для анализа
            var i = start;
            var sum = 0; // Инициализация суммы

            while (i <= finish)
            {
                // Двигаемся до конца диапазона
                sum = sum + i; // Считаем сумму для каждого числа
                i = i + 1; // Переходим к следующему числу в диапазоне
            }

            // Возвращаем получившийся результат
            return sum;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(App.SumNumbersFromRange(5, 7)); // 5 + 6 + 7 = 18
            Console.WriteLine(App.SumNumbersFromRange(1, 2)); // 1 + 2 = 3
            Console.ReadKey();

            // [1, 1] диапазон с одинаковым началом и концом – тоже диапазон
            // он в себя включает ровно одно число – саму границу диапазона
            Console.WriteLine(App.SumNumbersFromRange(1, 1)); // 1
            Console.WriteLine(App.SumNumbersFromRange(100, 100)); // 100
            Console.ReadKey();
        }
    }
}