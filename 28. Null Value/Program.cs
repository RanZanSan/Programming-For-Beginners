using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28.Null_Value
{
    class Program
    {
        static void Main(string[] args)
        {
            // Определение переменной с инициализацией null
            // С var такое не сработает, так как невозможно вывести тип
            string a = null;

            /*
             * var user = 
             * тут делаем запрос в базу
             * Если данных нет, то user станет null
             * Запись выше равносильна
             * var user = null;
             */

            // int x = null; // error CS0037: Cannot convert null to 'int' because it is a non-nullable value type
        }
    }
}