using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Variables_And_Concatenation.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var info = "We couldn't verify you mother's maiden name.";
            var intro = "Here is important information about your account security.";
            var firstName = "Joffrey";
            var greeting = "Hello";

            Console.WriteLine(greeting + ", " + firstName + "!" + "\n" + intro + "\n" + info);
            Console.ReadKey();
        }
    }
}