using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Expressions_In_Definitions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Для начала переведем 50 евро в доллары. Допустим, что один евро — 1.25 доллара:
            var dollarsCount = 50 * 1.25;
            Console.WriteLine(dollarsCount);
            Console.ReadKey();

            /*
             * Любая строка — выражение. Конкатенация строк — тоже выражение.
             * Когда программа видит выражение, она вычисляет его и возвращает результат.
             * Вот несколько примеров выражений, а в комментариях справа от каждого выражения — итоговое значение:
             * 
             * 62.5            // 62.5
             * 50 * 1.25       // 62.5
             * 120 / 10 * 2    // 24
             * 
             * "Hexlet"         // "Hexlet"
             * "Good" + "will" // "Goodwill"
             */

            // Вычислим цену 50 евро в долларах, умножив их на 1.25. Допустим, что 1 доллар — 60 рублей:
            var rublesPerDollar = 60;
            dollarsCount = 50 * 1.25; // 62.5
            var rublesCount = dollarsCount * rublesPerDollar; // 3750

            Console.WriteLine(rublesCount); // => 3750
            Console.ReadKey();

            // А теперь давайте добавим к выводу текст с помощью конкатенации:
            rublesPerDollar = 60;
            dollarsCount = 50 * 1.25; // 62.5
            rublesCount = dollarsCount * rublesPerDollar; // 3750

            Console.WriteLine("The price is " + rublesCount + " rubles"); // => The price is 3750 rubles
            Console.ReadKey();
        }
    }
}