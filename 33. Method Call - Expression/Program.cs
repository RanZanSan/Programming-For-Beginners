using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33.Method_Call___Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            // Математические операции (сложение, вычитание), строковые операции (конкатенация) – все это выражения:
            Console.WriteLine(1 + 5 * 3);
            Console.WriteLine("Hex" + "Let");
            Console.ReadKey();
            // Переменные могут быть частью выражения
            var rate = 1;
            Console.WriteLine(rate * 5);
            Console.ReadKey();

            // Особенность выражений в том, что они возвращают результат, который можно, например, присвоить переменной или вывести на экран. Например:
            var sum = 1 + 5;
            Console.WriteLine(sum); // Тут выражение это 1 + 5
            Console.ReadKey();

            // Но не все в программировании является выражением. Определение переменной это инструкция, она не может быть частью выражения. То есть такой код выдаст ошибку:
            // Бессмысленный код, который не сработает: 10 + var sum = 1 + 5;

            // Вот как можно получить индекс последнего символа в слове:
            var name = "Stark";
            // Получение свойства и вычитание вместе!
            var lastIndex = name.Length - 1;
            Console.WriteLine(lastIndex); // 4
            Console.ReadKey();

            // В этом коде нет нового синтаксиса. Мы всего лишь соединили уже известные части опираясь на их природу.Можно пойти еще дальше:
            name = "Stark";
            Console.WriteLine(name.Length - 1); // 4
            Console.ReadKey();

            // Все это справедливо для любых методов, например строковых:
            name = "Stark"; // ToUpper() – переводит слово в верхний регистр
            Console.WriteLine("House " + name.ToUpper()); // "House STARK"
            Console.ReadKey();
        }
    }
}