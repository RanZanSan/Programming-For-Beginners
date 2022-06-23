using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48.Negation
{
    class App
    {
        // Если есть метод, проверяющий чётность числа, то с помощью отрицания можно выполнить проверку нечётности:
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(App.IsEven(10)); // true
            Console.WriteLine(!App.IsEven(10)); // false
            Console.ReadKey();


            // То есть мы просто добавили ! слева от вызова метода и получили обратное действие.
            // Отрицание можно применять не только к вызову метода, но и к целому выражению:

            // x не равен 5 и не равен 3
            // (x == 5 && x == 3)

            // Это же выражение можно записать по другому
            //x != 5 || x != 3
        }
    }
}