using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Concatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Оператор такой же, как и при сложении чисел
            // но здесь он имеет другой смысл (семантику)
            Console.WriteLine("Dragon" + "stone"); // => Dragonstone
            Console.ReadKey();

            Console.WriteLine("Kings" + "wood"); // => Kingswood
            // Обратный порядок слов
            Console.WriteLine("road" + "Kings"); // => roadKings
            // Конкатенировать можно абсолютно любые строки
            Console.WriteLine("King's" + "Landing"); // => King'sLanding
            Console.ReadKey();

            // Ставим пробел в левой части
            Console.WriteLine("King's " + "Landing"); //  => King's Landing
            // Ставим пробел в правой части
            Console.WriteLine("King's" + " Landing"); //  => King's Landing
            // Добавляем пробел отдельно
            Console.WriteLine("King's" + " " + "Landing"); //  => King's Landing
            Console.ReadKey();

            Console.WriteLine("King's " + " Landing");   // => King's  Landing
            Console.WriteLine("King's  " + "  Landing"); // => King's    Landing
            Console.ReadKey();
        }
    }
}