using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Quotes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Goodbye");
            Console.WriteLine("G");
            Console.WriteLine(" ");
            Console.WriteLine("");
            Console.ReadKey();
            /*
             * Какие из этих пяти вариантов — строки?
             * С первыми двумя все понятно, это точно строки, мы уже работали с подобными конструкциями.
             * А что насчет остальных? Любой одиночный символ в кавычках — это строка.
             * Пустая строка "" — это тоже строка. То есть строкой мы считаем всё, что находится внутри кавычек,
             * даже если это пробел, один символ или вообще отсутствие символов.
             */

            /*
             * Представьте, что вы хотите напечатать строчку dragon's mother.
             * Апостроф перед буквой s — это такой же символ, как одинарная кавычка.
             * Такой вариант программы отработает корректно:
             */
            Console.WriteLine("Dragon's mother");
            Console.ReadKey();

            // А что, если мы хотим создать такую строку: Dragon's mother said "No"
            // Завершится с синтаксической ошибкой - Console.WriteLine("Dragon's mother said "No"");
            Console.WriteLine("Dragon's mother said \"No\"");
            Console.ReadKey();
        }
    }
}