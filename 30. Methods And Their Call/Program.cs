using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30.Methods_And_Their_Call
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Начнем с простых методов для работы над строками.
             * Ниже пример вызова метода ToUpper(), который переводит все слово в верхний регистр:
             * "hexlet".ToUpper(); // HEXLET
             */

            // Рассмотрим еще несколько примеров с добавлением переменных:
            var company = "Hexlet";

            var upperCompany = company.ToUpper();
            Console.WriteLine(upperCompany); // => "HEXLET"

            var lowerCompany = company.ToLower();
            Console.WriteLine(lowerCompany); // => "hexlet"
            Console.ReadKey();

            // Но это не обязательно, мы можем использовать методы напрямую:
            company = "Hexlet";
            Console.WriteLine(company.ToUpper()); // => HEXLET
            Console.ReadKey();

            var companyLength = "Hexlet".Length;
            Console.WriteLine(companyLength); // => 6
            // Свойство Length у строки возвращает ее длину.
            Console.ReadKey();
        }
    }
}