using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47.Logical_Operators.Teacher_s_Decision
{
    class App
    {
        public static bool IsLannisterSoldier(string color, string shield)
        {
            return (color == "red" && shield == null) || shield == "lion";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(App.IsLannisterSoldier("red", "lion")); // true
            Console.WriteLine(App.IsLannisterSoldier("blue", null));  // false
            Console.ReadKey();
        }
    }
}