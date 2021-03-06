using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51.if_else_Construct
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Условная конструкция if имеет несколько разновидностей, одна из которых включает в себя блок, выполняющийся в случае если условие ложно. Пример:
             * 
             * if (x > 5)
             * {
             *      // Если условие true
             * }
             * else
             * {
             *      // Если условие false
             * }
             */

            /*
             * Такая структура может понадобится при начальной инициализации значения.
             * В примере ниже проверяется, если email отсутствует, то устанавливаем значение по умолчанию, если его передали, то выполняем нормализацию.
             * 
             * // Где-то здесь приходит email
             * if (email.Equals(""))
             * {
             *      // Если email пустой, то ставим дефолт
             *      email = "support@hexlet.io";
             * }
             * else
             * {
             *      // иначе чистим
             *      email = email.Trim().ToLower();
             * }
             * 
             * // Здесь используем эту почту
             */

            /*
             * Если ветка if содержит return, то else становится не нужен и его можно просто опустить:
             * 
             * if (условие)
             * {
             *      return какое-то значение;
             * }
             * 
             * // продолжаем что-то делать
             * // else не нужен
             */

            Console.ReadKey();
        }
    }
}