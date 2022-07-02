using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52.else_if_Construct.Task
{
    class App
    {
        public static string WhoIsThisHouseToStarks(string family)
        {
            if ((family == "Karstark") || (family == "Tally"))
                return "friend";
            else if ((family == "Lannister") || (family == "Frey"))
                return "enemy";
            else
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