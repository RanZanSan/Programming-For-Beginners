using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41.Returning_Values
{
    class App
    {
        // Методы, которые мы определяли в предыдущих уроках, заканчивали свою работу тем, что печатали на экран какие-то данные:
        public static void Email()
        {
            // В реальности email приходит из формы
            var email = "  SuppORT@hexlet.IO";
            // обрезаем пробельные символы
            var trimmedEmail = email.Trim();
            // приводим к нижнему регистру
            var preparedEmail = trimmedEmail.ToLower();
            Console.WriteLine(preparedEmail); // => "support@hexlet.io"
                                              // здесь будет запись в базу данных
        }

        // Описать тип возвращаемых данных.В нашем случае это строка string
        // Выполнить возврат вместо печати на экран
        public static string Greeting()
        {
            Console.WriteLine("Я появлюсь в консоли");
            return "Winter is coming!";
            // Любой код ниже не выполнится никогда
            Console.WriteLine("Я никогда не выполнюсь");
        }

        // Здесь мы не возвращаем переменную, возвращается всегда значение, которое находится в этой переменной. Ниже пример с вычислениями:
        public static long DoubleFive()
        {
            // или return 5 + 5;
            var result = 5 + 5;
            return result;
        }
        // В этом примере в определении метода использовался long так как возвращается целое число.

        // Вопрос на самопроверку. Что вернёт этот метод?
        // Определение
        public static int Run()
        {
            return 5;
            return 10;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            App.Email();
            Console.ReadKey();

            var message = App.Greeting();

            Console.WriteLine(message.ToUpper()); // => "WINTER IS COMING!"
            Console.ReadKey();

            var result = App.DoubleFive();

            Console.WriteLine(result);
            Console.ReadKey();

            var test = App.Run();
            Console.WriteLine(test);
            Console.ReadKey();
        }
    }
}