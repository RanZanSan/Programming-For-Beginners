using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Variables_And_Concatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Переменные и конкатенацию можно объединять. Синтаксически ничего не меняется: мы умеем конкатенировать (склеивать) две строки:
            var what = "Kings" + "road";
            Console.WriteLine(what); // => "Kingsroad"
            Console.ReadKey();

            // … а значит сумеем конкатенировать строку и одну переменную, в которой записана строка:
            var first = "Kings";
            what = first + "road";

            Console.WriteLine(what); // => "Kingsroad"
            Console.ReadKey();

            // … и даже конкатенировать две переменные, в которых записаны строки:
            first = "Kings";
            var last = "road";
            what = first + last;

            Console.WriteLine(what); //=> "Kingsroad"
            Console.ReadKey();
        }
    }
}