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

            int countCastles = 6;
            int countRoomsOneCastle = 17;

            int totalCountRooms = countCastles * countRoomsOneCastle;

            Console.WriteLine(king + " has " + totalCountRooms + " rooms.");
            Console.ReadKey();
        }
    }
}