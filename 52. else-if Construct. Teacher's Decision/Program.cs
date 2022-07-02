using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52.else_if_Construct.Teacher_s_Decision
{
    class App
    {
        public static string WhoIsThisHouseToStarks(string houseName)
        {
            if (houseName == "Karstark" || houseName == "Tally")
            {
                return "friend";
            }
            else if (houseName == "Lannister" || houseName == "Frey")
            {
                return "enemy";
            }

            return "neutral";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(App.WhoIsThisHouseToStarks("Karstark")); // "friend"
            Console.WriteLine(App.WhoIsThisHouseToStarks("Frey")); // "enemy"
            Console.WriteLine(App.WhoIsThisHouseToStarks("Joar")); // "neutral"
            Console.WriteLine(App.WhoIsThisHouseToStarks("Ivanov")); // "neutral"
            Console.ReadKey();
        }
    }
}