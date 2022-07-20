using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40.Creating__Defining__A_Method.Class_Declaration
{
    class App
    {
        // ...

        // Определение метода
        public static void ShowCurrentDate()
        {
            // ...
        }

        // Минимальное определение метода
        public static void Noop()
        {
            // Тут мог бы быть код, но его нет
            // Обратите внимание на отступы
            // Для читаемости, любой код внутри тела сдвигается вправо на 4 пробела
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            // Console – "контейнер" для инструментов работы с консолью
            // WriteLine() – "инструмент" для вывода информации в консоль
            Console.ReadKey();

            // вызовет ошибку компиляции:
            // error CS0122: 'App.ShowCurrentDate()' is inaccessible due to its protection level
            App.ShowCurrentDate();

            App.Noop();

            Console.ReadKey();
        }
    }
}