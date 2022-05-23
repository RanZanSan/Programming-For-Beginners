using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Quotes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Такой вариант программы отработает корректно:
            Console.WriteLine("Dragon's mother");
            Console.ReadKey();

            // А что, если мы хотим создать такую строку: Dragon's mother said "No"
            // Завершится с синтаксической ошибкой - Console.WriteLine("Dragon's mother said "No"");
            Console.WriteLine("Dragon's mother said \"No\"");
        }
    }
}