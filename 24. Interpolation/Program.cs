using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.Interpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            // В уроке про конкатенацию перед нами стояла задача создать заголовок письма из двух констант и знаков препинания. Вы, скорее всего, решили задачу так:
            var firstName = "Joffrey";
            var greeting = "Hello";

            Console.WriteLine(greeting + ", " + firstName + "!");
            // => "Hello, Joffrey!"
            Console.ReadKey();

            //Есть другой, более удобный и изящный способ решения той же задачи — интерполяция. Вот, как это выглядит:
            firstName = "Joffrey";
            greeting = "Hello";

            // Обратите внимание на знак доллара перед началом строки
            Console.WriteLine($"{greeting}, {firstName}!");
            // => "Hello, Joffrey!"
            Console.ReadKey();
        }
    }
}