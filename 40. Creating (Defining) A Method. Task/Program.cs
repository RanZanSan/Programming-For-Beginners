using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40.Creating__Defining__A_Method.Task
{
    class App
    {
        public static void PrintMotto()
        {
            var text = "Winter is coming";
            Console.WriteLine(text);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            App.PrintMotto();
            Console.ReadKey();
        }
    }
}