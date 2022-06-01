using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26.Explicit_Typing
{
    class Program
    {
        static void Main(string[] args)
        {
            // До сих пор при определении переменных мы использовали ключевое слово var, и обычно это рекомендуемый способ объявления. Но еще переменные можно объявлять вот так:
            int x = 3;
            string greeting = "Hello Hexlet!";

            // int ops = "test"; // error CS0029: Cannot implicitly convert type 'string' to 'int'
            Console.ReadKey();
        }
    }
}