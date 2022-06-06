using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31.Method_Parameters.Teacher_s_Decision
{
    class Program
    {
        static void Main(string[] args)
        {
            var one = "Naharis";
            var two = "Mormont";
            var three = "Sand";

            var char1 = one[2];
            var char2 = two[1];
            var char3 = three[3];
            var char4 = two[4];
            var char5 = two[2];

            Console.WriteLine($"{char1} {char2} {char3} {char4} {char5}");
            Console.ReadKey();
        }
    }
}