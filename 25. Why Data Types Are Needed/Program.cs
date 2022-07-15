using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.Why_Data_Types_Are_Needed
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Язык программирования распознает типы.
             * Поэтому C# не позволит нам умножать строку на строку.
             * Но позволит умножать целое число на другое целое число.
             * Наличие типов и таких ограничений в языке защищает программы от случайных ошибок.
             * "one" * "two"
             * error CS0019: Operator '*' cannot be applied to operands of type 'string' and 'string'
             */

            // Компилятор понимает что тут число
            var age = 33;
            Console.WriteLine(age);
            Console.ReadKey();
        }
    }
}