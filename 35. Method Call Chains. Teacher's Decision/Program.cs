using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35.Method_Call_Chains.Teacher_s_Decision
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "hexlet";

            var capitalized = name.Substring(0, 1).ToUpper()
                            + name.Substring(1).ToLower();

            Console.WriteLine(capitalized);
            Console.ReadKey();
        }
    }
}