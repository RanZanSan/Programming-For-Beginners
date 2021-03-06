using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _60.Forming_Strings_In_Loops
{
    class App
    {
        public static string Reverse(string str)
        {
            var i = 0;
            // Нейтральный элемент для строк это пустая строка
            var result = "";
            while (i < str.Length)
            {
                // Соединяем в обратном порядке
                result = str[i] + result;
                i = i + 1;
            }

            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(App.Reverse("Hexlet")); // telxeH

            var name = "Bran";
            Console.WriteLine(App.Reverse(name)); // "narB"
            // Проверка нейтрального элемента
            Console.WriteLine(App.Reverse("")); // ""
            Console.ReadKey();
        }
    }
}