using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36.Determinism
{
    class Functions
    {
        public static double RandomDouble()
        {
            Random random = new Random();
            double randomNumber = random.NextDouble();
            return randomNumber;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Метод называется детерминированным тогда, когда для одних и тех же входных аргументов он возвращает один и тот же результат.
            // Например, метод, находящий номер символа в строке, детерминированный
            Console.WriteLine("wow".IndexOf('o')); // 1
            Console.WriteLine("wow".IndexOf('o')); // 1
            Console.ReadKey();

            // Даже если хотя бы один из миллиона вызовов вернет что-то другое, этот метод автоматически считается недетерминированным.
            Console.WriteLine(Functions.RandomDouble()); // 0.9421500302020687
            Console.WriteLine(Functions.RandomDouble()); // 0.5468204760759785
            Console.ReadKey();
        }
    }
}