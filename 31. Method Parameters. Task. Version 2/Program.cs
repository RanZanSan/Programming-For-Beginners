using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31.Method_Parameters.Task.Version_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var one = "Naharis";
            var two = "Mormont";
            var three = "Sand";

            char a = one[2];
            char b = two[1];
            char c = three[3];
            char d = two[4];
            char e = two[2];

            Console.WriteLine($"{a} {b} {c} {d} {e}");
            Console.ReadKey();
        }
    }
}