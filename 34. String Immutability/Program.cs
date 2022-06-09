using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34.String_Immutability
{
    class Program
    {
        static void Main(string[] args)
        {
            // Попробуйте ответить на вопрос, что выведет на экран следующий код?
            var company = "hexlet";
            company.ToUpper(); // в верхний регистр
            Console.WriteLine(company); // => ?
            Console.ReadKey();

            // Но как же все таки поступать, если данные нужно поменять? Для этого достаточно заменить значение переменной:
            var name = "HODOR";
            name = name.ToLower();
            Console.WriteLine(name); // => "hodor"
            Console.ReadKey();

            // С другой стороны, именно в такой ситуации можно создать новую переменную, с другим именем.
            name = "HODOR";
            var processedName = name.ToLower();
            Console.WriteLine(processedName); // => "hodor"
            Console.ReadKey();
        }
    }
}