using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Место откуда берется класс с методом
// using MailerLib;

namespace _40.Creating__Defining__A_Method
{
    // Объявление класса
    class App
    {
        // Определение метода
        public static void ShowCurrentDate()
        {
            // Класс со свойством для получения текущего времени
            var currentDate = DateTime.Now;
            var text = $"Today is: {currentDate}";
            Console.WriteLine(text);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Благодаря возможности определять методы, вся сложность может быть скрыта за одним простым методом:
            var email = "support@hexlet.io";
            var title = "Помогите";
            var body = "Я написал историю успеха, как я могу получить скидку?";

            // Mailer – имя класса по аналогии с Console, который мы уже многократно использовали
            // Один маленький вызов — и много логики внутри
            // Mailer.Send(email, title, body);

            // Создадим наш первый метод. Его задача -вывести на экран текущую дату:
            // Today is: 2021-10-25

            // Вызов метода
            // Обязательно указывать имя класса
            App.ShowCurrentDate(); // => "Today is: 09.12.2021 10:52:13"
            Console.ReadKey();
        }
    }
}