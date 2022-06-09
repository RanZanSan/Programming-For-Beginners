using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32.Properties.Teacher_s_Decision
{
    class Program
    {
        static void Main(string[] args)
        {
            var kingName = "Robert I Baratheon";
            var kingNameLength = kingName.Length;

            Console.WriteLine($"{kingName} has {kingNameLength} characters in his name");
            Console.ReadKey();
        }
    }
}