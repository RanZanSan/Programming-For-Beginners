using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.What_Is_A_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Представьте себе задачу, нам нужно напечатать на экран фразу Father! два раза или даже пять раз. Эту задачу можно решить в лоб:
            Console.WriteLine("Father!"); // => Father!
            Console.WriteLine("Father!"); // => Father!
            Console.ReadKey();

            // greeting – переводится как приветствие
            // var – нужен только при определении переменной
            // что это и почему, мы поговорим в одном из следующих уроков
            var greeting = "Father!";
            Console.WriteLine(greeting); // => Father!
            Console.WriteLine(greeting); // => Father!
            Console.ReadKey();

            var greeting1 = "Father!";
            Console.WriteLine(greeting1); // => Father!
            Console.WriteLine(greeting1); // => Father!

            var greeting2 = "Mother!";
            Console.WriteLine(greeting2); // => Mother!
            Console.WriteLine(greeting2); // => Mother!
            Console.ReadKey();

            // Нельзя давать переменных имена, совпадающие с ключевыми словами языка.
            var @var = "i am var";
            Console.WriteLine(@var);
            Console.ReadKey();
        }
    }
}