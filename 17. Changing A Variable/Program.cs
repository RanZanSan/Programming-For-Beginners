using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Changing_A_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Само слово «переменная», говорит о том, что ее можно менять. И действительно, с течением времени внутри программы, значения переменных могут изменяться.
            var greeting = "Father!";
            Console.WriteLine(greeting);
            Console.WriteLine(greeting);
            Console.ReadKey();

            // var уже не используется, так как переменная была определена выше
            greeting = "Mother!";
            Console.WriteLine(greeting);
            Console.WriteLine(greeting);
            Console.ReadKey();

            /*
             * C# статически типизированный язык, это значит что тип переменной задается при определении и больше не меняется.
             * В примере выше, при создании переменной, мы присвоили ей строку. Компилятор запоминает тип и проверяет все последующие изменения переменной.
             * Если попробовать этой же переменной присвоить число, то мы получим следующую ошибку:
             * 
             * greeting = 5;
             * # error CS0029: Cannot implicitly convert type 'int' to 'string'
             */
        }
    }
}