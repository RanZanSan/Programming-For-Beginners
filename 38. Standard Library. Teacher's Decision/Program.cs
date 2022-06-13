using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38.Standard_Library.Teacher_s_Decision
{
    class Program
    {
        static void Main(string[] args)
        {
            var war = "War of the Kings";
            var missingWord = "Five ";

            var kingWordIndex = war.IndexOf('K');
            Console.WriteLine(war.Insert(kingWordIndex, missingWord));
            Console.ReadKey();
        }
    }
}