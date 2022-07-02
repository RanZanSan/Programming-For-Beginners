using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54.Switch_Construction
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Многие языки в дополнение к условной конструкции if включают в себя switch.
             * Это специализированная версия if, созданная для некоторых особых ситуаций.
             * Например, её имеет смысл использовать там, где есть цепочка if else с проверками на равенство. Например:
             * 
             * if (status.equals("processing"))
             * {
             *      // Делаем раз
             * }
             * else if (status.equals("paid"))
             * {
             *      // Делаем два
             * }
             * else if (status.equals("new"))
             * {
             *      // Делаем три
             * }
             * else
             * {
             *      // Делаем четыре
             * }
             */

            /*
             * Эта составная проверка обладает одной отличительной чертой:
             * каждая ветка здесь — это проверка значения переменной status.
             * Switch позволяет записать этот код короче и выразительнее:
             * 
             * switch (status)
             * {
             *      case "processing":
             *          // Делаем раз
             *          break;
             *      case "paid":
             *          // Делаем два
             *          break;
             *      case "new":
             *          // Делаем три
             *          break;
             *      default: // else
             *          // Делаем четыре
             *          break;
             * }
             */

            /*
             * Фигурные скобки в switch не определяют блок кода, как это было в других местах.
             * Внутри допустим только тот синтаксис, который показан выше.
             * То есть там можно использовать case или default.
             * А вот внутри каждого case (и default) ситуация другая.
             * Здесь можно выполнять любой произвольный код:
             * 
             * switch (count)
             * {
             *      case 1:
             *          // Делаем что-то полезное
             *          break;
             *      case 2:
             *          // Делаем что-то полезное
             *          break;
             *      default:
             *          // Что-то делаем
             *          break;
             * }
             */
        }
    }
}