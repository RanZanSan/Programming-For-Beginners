using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36.Determinism.Task
{
    class Functions
    {
        public static double RandomDouble()
        {
            Random random = new Random();
            double randomNumber = random.NextDouble();
            return randomNumber;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Convert.ToInt32(Functions.RandomDouble() * 10));
            Console.ReadKey();
        }
    }
}