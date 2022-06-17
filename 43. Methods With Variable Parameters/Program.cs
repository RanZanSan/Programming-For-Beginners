using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Мы хотим написать метод, который будет помогать северянам давать имена своим детям:

namespace _43.Methods_With_Variable_Parameters
{
    class North
    {
        // Если фамилия неизвестна, то мы хотим чтобы автоматически подставлялась фамилия Snow.Вот так это делается:
        public static string PickName(string name = "Bran", string surname = "Snow")
        {
            return $"{name} {surname}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(North.PickName("Sansa", "Stark")); // "Sansa Stark"
            Console.WriteLine(North.PickName("Meera", "Reed")); // "Meera Reed"
            Console.ReadKey();

            Console.WriteLine(North.PickName("Bran", "Stark")); // "Bran Stark"
            Console.WriteLine(North.PickName("John")); // "John Snow"
            Console.ReadKey();

            Console.WriteLine(North.PickName()); // "Bran Snow"
            Console.ReadKey();
        }
    }
}