using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47.Logical_Operators
{
    class App
    {
        // Пароль длиннее 8 символов **И** пароль короче 20 символов.
        public static bool IsCorrectPassword(string password)
        {
            var length = password.Length;
            return length > 8 && length < 20;
        }

        // Напишем метод, проверяющий квартиру. Он принимает два параметра: площадь (число) и название улицы (строку):
        public static bool IsGoodApartment(int area, string street)
        {
            return area >= 100 || (area >= 80 && "Main Street" == street);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(App.IsCorrectPassword("qwerty")); // false
            Console.WriteLine(App.IsCorrectPassword("qwerty1234")); // true
            Console.ReadKey();

            // Другой пример. Мы хотим купить квартиру, которая удовлетворяет условиям:
            // площадь от 100 кв. метров и больше на любой улице ИЛИ площадь от 80 кв. метров и больше, но на центральной улице Main Street.
            Console.WriteLine(App.IsGoodApartment(91, "Queens Street")); // false
            Console.WriteLine(App.IsGoodApartment(78, "Queens Street")); // false
            Console.WriteLine(App.IsGoodApartment(70, "Main Street")); // false
            Console.ReadKey();

            Console.WriteLine(App.IsGoodApartment(120, "Queens Street")); // true
            Console.WriteLine(App.IsGoodApartment(120, "Main Street")); // true
            Console.WriteLine(App.IsGoodApartment(80, "Main Street")); // true
            Console.ReadKey();
        }
    }
}