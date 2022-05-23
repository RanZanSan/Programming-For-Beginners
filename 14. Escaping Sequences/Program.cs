using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Escaping_Sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Мы хотим показать диалог Матери Драконов со своим ребёнком:
             * - Are you hungry?
             * - Aaaarrrgh!
             * Если вывести на экран строку с таким текстом:
             */
            Console.WriteLine("- Are you hungry?- Aaaarrrgh!"); // то получится так: - Are you hungry?- Aaaarrrgh!
            Console.ReadKey();

            Console.WriteLine("- Are you hungry?\n- Aaaarrrgh!");
            /*
             * результат:
             * - Are you hungry?
             * - Aaaarrrgh!
             */
            Console.ReadKey();

            Console.WriteLine("Gregor Clegane\nDunsen\nPolliver\nChiswyck");
            /* Gregor Clegane
             * Dunsen
             * Polliver
             * Chiswyck
             */
            Console.ReadKey();

            // Обратите внимание на следующие моменты:
            Console.WriteLine("\n");
            Console.WriteLine("Dunsen");
            /*
             *  
             *  
             *  Dunsen
             */
            Console.ReadKey();

            // Ещё пример кода:
            Console.WriteLine("Polliver");
            Console.WriteLine("Gregor Clegane");
            Console.WriteLine();
            Console.WriteLine("Chiswyck");
            Console.WriteLine("\n");
            Console.WriteLine("Dunsen");
            /*
             * Polliver
             * Gregor Clegane
             * 
             * Chiswyck
             * 
             * 
             * 
             * Dunsen
             */
            Console.ReadKey();

            Console.WriteLine("Joffrey loves using \\n"); // на экран выйдет: Joffrey loves using \n
            Console.ReadKey();
        }
    }
}