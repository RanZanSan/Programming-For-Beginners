using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Code_Design_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * В любом языке программирования существуют утилиты — так называемые линтеры.
             * Они проверяют код на соответствие стандартам, и могут сами поправить небольшие отклонения от стандарта.
             * Для C# линтер является частью Visual Studio. Либо есть отдельная программа dotnet format
             * 
             * Взгляните на пример:
             */
            Console.WriteLine(8/2+5 - -3 / 2); // dotnet format будет «ругаться» на нарушение сразу в нескольких местах:
            Console.ReadKey();
            /*
             * Program.cs(1,27): error WHITESPACE: Fix whitespace formatting. Insert ' '
             * Program.cs(1,28): error WHITESPACE: Fix whitespace formatting. Insert ' '
             * Program.cs(1,29): error WHITESPACE: Fix whitespace formatting. Insert ' '
             * Program.cs(1,30): error WHITESPACE: Fix whitespace formatting. Insert ' '
             */

            /*
             * Program.cs – это имя файла в котором линтер нашел нарушение.
             * Числа в скобка означают номер строки и символа в котором было обнаружено нарушение правил.
             * WHITESPACE – правило, которое было нарушено.
             * Это правило требует наличия пробелов между операторами и операндами.
             * Оно не влияет на результат, но помогает писать код понятнее и проще для восприятия.
             * Код с учетом этого правила выглядит так:
             */
            Console.WriteLine(8 / 2 + 5 - -3 / 2);
            Console.ReadKey();

            // Теперь линтер ругаться не будет, но код все равно сложен для восприятия из-за отсутствия скобок. Лучше сделать так:
            Console.WriteLine((8 / 2) + 5 - (-3 / 2));
            Console.ReadKey();
        }
    }
}