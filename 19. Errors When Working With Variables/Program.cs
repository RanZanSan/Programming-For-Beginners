using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Errors_When_Working_With_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Console.WriteLine(greeting);
             * greeting = "Father!";
             * Запуск программы выше завершается с ошибкой:
             * error CS0103: The name 'greeting' does not exist in the current context
             */

            /*
             * Еще одна распространенная ошибка — попытаться объявить уже объявленную переменную:
             * var greeting = "Father!";
             * var greeting = "Father!";
             * Так делать нельзя. Придётся создать новую переменную.
             */
        }
    }
}