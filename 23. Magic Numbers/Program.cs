using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Magic_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Перевод евро в рубли через доллары
            var euros = 1000;
            var dollars = euros * 1.25; // 1250
            var rubles = dollars * 60; // 75000

            Console.WriteLine(rubles); // => 75000
            Console.ReadKey();

            // Выход из ситуации прост: достаточно создать переменные с правильными именами, как все встанет на свои места.
            var dollarsInEuro = 1.25;
            var roublesInDollar = 60;

            euros = 1000;
            dollars = euros * dollarsInEuro; // 1250
            rubles = dollars * roublesInDollar; // 75000

            Console.WriteLine(rubles); // => 75000
            Console.ReadKey();
        }
    }
}