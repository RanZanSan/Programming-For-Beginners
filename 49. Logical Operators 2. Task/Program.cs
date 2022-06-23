using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49.Logical_Operators_2.Task
{
    class App
    {
        public static bool IsNeutralSoldier(string armorColor, string shieldColor)
        {
            return armorColor != "red" && shieldColor == "black";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(App.IsNeutralSoldier("yellow", "black")); // true
            Console.WriteLine(App.IsNeutralSoldier("red", "black")); // false
            Console.WriteLine(App.IsNeutralSoldier("red", "red")); // false
            Console.ReadKey();
        }
    }
}