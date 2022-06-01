using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29.Explicit_Type_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // станет int
            var number = Convert.ToInt32("345");
            Console.WriteLine(number); // => 345
            Console.ReadKey();

            /*
             * Если нужно конвертировать из примитивного типа в примитивный, то все проще.
             * Достаточно перед значением в скобках указать желаемый тип.
             * В результате значение справа преобразуется в значение другого типа, указанного слева:
             * (int) 5.1; // 5
             */

            // Дополнительные скобки помогают визуально отделить части выражения друг от друга
            Console.WriteLine(10 + ((int)5.1)); // => 15
            Console.ReadKey();
        }
    }
}