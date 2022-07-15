using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Statements__Инструкции_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mother of Dragons");
            Console.WriteLine("Dracarys!");
            // При запуске этого кода на экран последовательно выводятся два предложения
            Console.ReadKey();

            // Теоретически инструкции можно написать последовательно друг за другом без переноса на новую строчку
            Console.WriteLine("Mother of Dragons."); Console.WriteLine("Dracarys!");
            // Результат на экране будет таким же, но на практике такой подход считается плохим
            Console.ReadKey();
        }
    }
}