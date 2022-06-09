using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34.String_Immutability.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var email = " SupporT@hexlet.io\n";
            Console.WriteLine(email.Trim().ToLower());
            Console.ReadKey();
        }
    }
}