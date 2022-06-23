using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Список операций сравнения в C#:
 * < меньше
 * <= меньше или равно
 * > больше
 * >= больше или равно
 * == равно
 * != не равно
 */

namespace _44.Boolean_Type
{
    public class App
    {
        // Метод возвращающий bool называется предикатом
        // Обычно такие методы имеют префикс has can is was и т.п.
        public static bool IsInfant(int age)
        {
            return age < 1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Это новый для нас тип данных — bool. Он содержит всего лишь два этих значения.
            var result = 5 > 4;
            Console.WriteLine(result); // => true
            Console.ReadKey();

            // В зависимости от пришедшего параметра, сравнение будет либо истинным (true), либо ложным (false), и return вернёт этот результат.
            Console.WriteLine(App.IsInfant(3)); // => false
            Console.WriteLine(App.IsInfant(0)); // => true
            Console.ReadKey();
        }
    }
}