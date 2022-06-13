using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39.What_Are_The_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Мы уже сталкивались с методами встроенными в C# в разных формах:
             * 
             * Console.WriteLine();
             * someString.ToLower();
             * someString.IndexOf();
             * File.ReadAllText();
             */

            /*
             * Из объектов мы пока сталкивались только со строками, но принцип одинаковый для любых объектов. Ниже несколько примеров:
             * 
             * Где-то здесь создаются объекты
             * 
             * извлекает имя у пользователя
             * user.GetName();
             * 
             * извлекает текущий день
             * currentDate.GetDayOfMonth();
             * 
             * проверка того, что файл существует
             * file.Exists();
             */

            /*
             * Еще примеры:
             * Вычисление квадратного корня. Вызов напрямую из класса Math
             * Math.Sqrt(4);
             * 
             * Чтение текста из указанного файла
             * File.ReadAllText("readme.txt");
             */
        }
    }
}