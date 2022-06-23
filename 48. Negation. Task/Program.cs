using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48.Negation.Task
{
    class App
    {
        public static bool IsLannisterSoldier(string color, string image)
        {
            return (color == "red" && image == null) || image == "lion";
        }

        public static bool IsNotLannisterSoldier(string color, string image)
        {
            return !((color == "red" && image == null) || image == "lion");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(App.IsLannisterSoldier("red", "lion")); // true
            Console.WriteLine(App.IsLannisterSoldier("blue", null));  // false
            Console.ReadKey();

            Console.WriteLine(App.IsLannisterSoldier("blue", null)); // false
            Console.WriteLine(App.IsLannisterSoldier("red", "man")); // false
            Console.WriteLine(App.IsLannisterSoldier("red", "lion")); // true
            Console.WriteLine(App.IsLannisterSoldier("blue", "lion")); // true
            Console.WriteLine(App.IsLannisterSoldier("red", null)); // true
            Console.ReadKey();

            Console.WriteLine(App.IsNotLannisterSoldier("red", "lion")); // false
            Console.WriteLine(App.IsNotLannisterSoldier("blue", null));  // true
            Console.ReadKey();

            Console.WriteLine(App.IsNotLannisterSoldier("blue", null)); // true
            Console.WriteLine(App.IsNotLannisterSoldier("red", null)); // false
            Console.WriteLine(App.IsNotLannisterSoldier("red", "man")); // true
            Console.WriteLine(App.IsNotLannisterSoldier("red", "lion")); // false
            Console.WriteLine(App.IsNotLannisterSoldier("blue", "lion")); // false
            Console.ReadKey();
        }
    }
}