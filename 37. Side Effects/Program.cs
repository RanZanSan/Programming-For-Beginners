using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37.Side_Effects
{
    class Program
    {
        static void Main(string[] args)
        {
            // Читаем содержимое файла в переменную
            var message = File.ReadAllText("message-from-stark.txt");
            // Выводим содержимое на экран
            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}