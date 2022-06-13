using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38.Standard_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            var war = "War of the Kings";
            var missingWord = "Five ";

            Console.WriteLine(war.Insert(11, missingWord));
            Console.ReadKey();
        }
    }
}