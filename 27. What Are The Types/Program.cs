using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27.What_Are_The_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            byte x = 3; // Отработает без проблем

            // byte y = 270; // error CS0031: Constant value '270' cannot be converted to a 'byte'
            Console.ReadKey();

            char ch = 'a';

            // char ch2 = "b"; // error CS0029: Cannot implicitly convert type 'string' to 'char'
            Console.ReadKey();

            // операция [] извлекает из строки символ с нужным номером. Нумерация начинается с 0
            Console.WriteLine("hexlet"[1]); // 'e'
            Console.ReadKey();
        }
    }
}