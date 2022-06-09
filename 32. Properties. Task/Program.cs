using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32.Properties.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Robert I Baratheon";
            int stringLength = name.Length;

            Console.WriteLine($"{name} has {stringLength} characters in his name");
            Console.ReadKey();
        }
    }
}