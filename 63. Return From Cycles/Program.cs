using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _63.Return_From_Cycles
{
    class App
    {
        public static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            var divider = 2;

            while (divider <= number / 2)
            {
                if (number % divider == 0)
                {
                    return false;
                }

                divider++;
            }

            return true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(App.IsPrime(1)); // false
            Console.WriteLine(App.IsPrime(2)); // true
            Console.WriteLine(App.IsPrime(3)); // true
            Console.WriteLine(App.IsPrime(4)); // false
            Console.ReadKey();
        }
    }
}