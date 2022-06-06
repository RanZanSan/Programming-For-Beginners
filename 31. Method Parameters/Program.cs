using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31.Method_Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Bran";
            // Находит номер указанного символа
            name.IndexOf('B'); // 0
            Console.WriteLine(name.IndexOf('B'));
            Console.ReadKey();

            name = "Bran";
            var nameLength = name.Length;
            var lastCharIndex = nameLength - 1;
            Console.WriteLine(name[lastCharIndex]); // 'n'
            Console.ReadKey();

            // Параметров может быть больше чем один. Например метод Replace() работает с двумя, где первый это что заменить и второй – на что.
            name = "Ramsay Snow";
            name.Replace("Snow", "Bolton"); // "Ramsay Bolton"
            Console.WriteLine(name.Replace("Snow", "Bolton"));
            Console.ReadKey();

            /* Простой пример – метод извлекающий подстроку (часть строки) из строки.
             * Первым параметром этот метод принимает на вход индекс с которого надо начать извлекать подстроку,
             * а вторым – длину извлекаемой подстроки.
             * По умолчанию берется строка до конца:
             */
            name = "Bran";
            Console.WriteLine(name.Substring(1));
            Console.WriteLine(name.Substring(1, 2));
            Console.WriteLine(name.Substring(1, 3));
            Console.WriteLine(name.Substring(2, 2));
            Console.ReadKey();

            // В частности, у строк есть индексатор.
            name = "Bran";
            Console.WriteLine(name[0]);
            Console.WriteLine(name[1]);
            Console.WriteLine(name[2]);
            Console.WriteLine(name[3]);
            Console.ReadKey();
        }
    }
}