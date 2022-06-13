using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39.What_Are_The_Methods.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var emoji = "-(";
            var smiley = emoji.Insert(0, ":").Replace("(", ")");

            Console.WriteLine(smiley);
            Console.ReadKey();
        }
    }
}