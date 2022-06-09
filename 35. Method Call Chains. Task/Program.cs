using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35.Method_Call_Chains.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "hexlet";
            Console.WriteLine(name.ToLower().Replace("h", "H"));
            Console.ReadKey();
        }
    }
}