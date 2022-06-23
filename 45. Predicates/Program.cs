using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * В C# предикаты, как правило, начинаются с префикса Is, Has или Can, но не ограничены этими словами. Примеры:
 * IsInfant() — «младенец ли?»
 * HasChildren() — «есть ли дети?»
 * IsEmpty() — «пустой ли?»
 * HasErrors() — «есть ли ошибки?»
 * Метод может считаться предикатом только если она возвращает bool.
 */

namespace _45.Predicates
{
    public class App
    {
        public static bool IsInfant(int age)
        {
            return age < 1;
        }

        // Давайте напишем ещё один метод-предикат. Он принимает строку и проверяет, является ли она словом 'Castle':
        public static bool IsCastle(string building)
        {
            return building == "Castle";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(App.IsInfant(3)); // => false
            Console.ReadKey();

            Console.WriteLine(App.IsCastle("Sea")); // => false
            Console.ReadKey();
        }
    }
}