using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39.What_Are_The_Methods.Teacher_s_Decision
{
    class Program
    {
        static void Main(string[] args)
        {
            var emoji = "-(";
            var happyEmoji = ":" + emoji.Replace('(', ')');

            Console.WriteLine(happyEmoji);
            Console.ReadKey();
        }
    }
}