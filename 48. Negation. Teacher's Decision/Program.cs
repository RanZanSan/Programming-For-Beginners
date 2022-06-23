using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48.Negation.Teacher_s_Decision
{
    class App
    {
        public static bool IsLannisterSoldier(string color, string shield)
        {
            return (color == "red" && shield == null) || shield == "lion";
        }

        public static bool IsNotLannisterSoldier(string color, string shield)
        {
            return !IsLannisterSoldier(color, shield);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(App.IsNotLannisterSoldier("red", "lion")); // false
            Console.WriteLine(App.IsNotLannisterSoldier("blue", null));  // true
            Console.ReadKey();
        }
    }
}