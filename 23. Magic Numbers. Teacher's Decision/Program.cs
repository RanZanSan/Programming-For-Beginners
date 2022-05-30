using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Magic_Numbers.Teacher_s_Decision
{
    class Program
    {
        static void Main(string[] args)
        {
            var king = "King Balon the 6th";

            var numberOfCastles = 6;
            var roomsPerCastle = 17;

            Console.WriteLine(king + " has " + numberOfCastles * roomsPerCastle + " rooms.");
            Console.ReadKey();
        }
    }
}