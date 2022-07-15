using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35.Method_Call_Chains.Task.Version_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "hexlet";

            var newName = name.Substring(0, 1).ToUpper();
            newName = newName + name.Substring(1).ToLower();

            Console.WriteLine(newName);
            Console.ReadKey();
        }
    }
}