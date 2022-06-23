using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44.Boolean_Type.Task
{
    public class App
    {
        public static bool IsPensioner(int age)
        {
            return age >= 60;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(App.IsPensioner(75)); // true
            Console.WriteLine(App.IsPensioner(18)); // false
            Console.ReadKey();
        }
    }
}