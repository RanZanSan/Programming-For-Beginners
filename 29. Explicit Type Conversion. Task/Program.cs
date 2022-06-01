using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29.Explicit_Type_Conversion.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = 2.9;
            string word = "times";

            Console.WriteLine((int)number + " " + word);
            Console.ReadKey();
        }
    }
}