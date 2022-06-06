using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Magic_Numbers.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var king = "King Balon the 6th";

            var countCastles = 6;
            var countRoomsOneCastle = 17;

            var totalCountRooms = countCastles * countRoomsOneCastle;

            Console.WriteLine(king + " has " + totalCountRooms + " rooms.");
            Console.ReadKey();
        }
    }
}