using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Expressions_In_Definitions.Teacher_s_Decision
{
    class Program
    {
        static void Main(string[] args)
        {
            var dollarsPerEuro = 1.25;
            var rublesPerDollar = 60;
            var eurosCount = 100;

            var dollarsCount = eurosCount * dollarsPerEuro;
            Console.WriteLine(dollarsCount);
            var rublesCount = dollarsCount * rublesPerDollar;
            Console.WriteLine(rublesCount);

            Console.ReadKey();
        }
    }
}