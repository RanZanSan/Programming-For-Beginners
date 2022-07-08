using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55.While_Loop
{
    class App
    {
        public static void PrintNumbers(int lastNumber)
        {
            // i сокращение от index (порядковый номер)
            // используется по общему соглашению во множестве языков
            // как счетчик цикла
            var i = 1;

            while (i <= lastNumber)
            {
                Console.WriteLine(i);
                i = i + 1;
            }

            Console.WriteLine("finished!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            App.PrintNumbers(3);
            Console.ReadKey();
        }
    }
}