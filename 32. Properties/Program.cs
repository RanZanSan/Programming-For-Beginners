using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32.Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            // Помимо методов у объектов могут быть еще свойства.
            Console.WriteLine("Hexlet".Length); // 6
            Console.ReadKey();

            /* 
             * Главная задача свойств – обеспечить доступ к внутренним данным класса или объекта.
             * Свойства очень похоже на методы – их тоже нужно вызывать, чтобы получить значение.
             * Скобочки при этом писать не надо.
             */
            var name = "Sansa";
            var house = "Stark";

            var totalSymbols = name.Length + house.Length;

            Console.WriteLine(totalSymbols);  // => 10
            Console.ReadKey();

            /* 
             * Свойства есть и у типов. Такие свойства называются статическими. 
             * Например у всех числовых типов (byte, short, int, long и т.д.) есть свойства MinValue и MaxValue.
             */
            Console.WriteLine(byte.MaxValue); // 255
            Console.WriteLine(short.MaxValue); // 32767
            Console.WriteLine(int.MaxValue); // 2147483647
            Console.WriteLine(long.MaxValue); // 9223372036854775807
            Console.ReadKey();
        }
    }
}