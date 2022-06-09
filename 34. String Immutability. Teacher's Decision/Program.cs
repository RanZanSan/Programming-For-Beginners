using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34.String_Immutability.Teacher_s_Decision
{
    class Program
    {
        static void Main(string[] args)
        {
            var email = " SupporT@hexlet.io\n";

            email = email.Trim();
            email = email.ToLower();

            Console.WriteLine(email);
            Console.ReadKey();
        }
    }
}