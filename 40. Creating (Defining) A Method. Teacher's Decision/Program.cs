using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40.Creating__Defining__A_Method.Teacher_s_Decision
{
    class App
    {
        public static void PrintMotto()
        {
            Console.WriteLine("Winter is coming");
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