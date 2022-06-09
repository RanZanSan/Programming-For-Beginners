using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35.Method_Call_Chains
{
    class Program
    {
        static void Main(string[] args)
        {
            // Название введенное пользователем. Для простоты на английском
            var name = " How match is the fish?   ";
            name = name.Trim(); // вырезаем концевые пробелы
            name = name.Replace("?", ""); // Удаляем вопрос
            name = name.Replace(" ", "-"); // Заменяем пробелы на дефис
            name = name.ToLower(); // в нижний регистр
            Console.WriteLine(name); // => "how-match-is-the-fish"
            Console.ReadKey();

            // Этот шаблон можно упростить, убрав промежуточное перезаписывание переменной:
            name = " How match is the fish?   ";
            name = name.Trim().Replace("?", "").Replace(" ", "-").ToLower();
            Console.WriteLine(name); // => "how-match-is-the-fish"
            Console.ReadKey();

            // Если цепочка методов становится слишком длинной, то ее можно разбить на несколько строк:
            name = " How match is the fish?   ";
            name = name.Trim()
                       .Replace("?", "")
                       .Replace(" ", "-")
                       .ToLower();
            Console.WriteLine(name);
            Console.ReadKey();

            // Для извлечения частей слова, воспользуйтесь методом Substring():
            var company = "hexlet";
            // 1 параметр – индекс, 2 – длина извлекаемой подстроки
            Console.WriteLine(company.Substring(0, 1)); // "h"
            Console.ReadKey();

            company = "hexlet";
            // По умолчанию до конца строки
            Console.WriteLine(company.Substring(1)); // "exlet"
            Console.ReadKey();
        }
    }
}