using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33.Method_Call___Expression.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "Never forget what you are, for surely the world will not";
            Console.WriteLine($"First: {text[0]}\nLast: {text[text.Length - 1]}");
            Console.ReadKey();
        }
    }
}