using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31.Method_Parameters.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var one = "Naharis";
            var two = "Mormont";
            var three = "Sand";

            Console.WriteLine(one[2] + " " + two[1] + " " + three[3] + " " + two[4] + " " + two[2]);
            Console.ReadKey();
        }
    }
}