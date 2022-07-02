using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51.if_else_Construct.Task
{
    class App
    {
        public static string NormalizeUrl(string address)
        {
            if(address.StartsWith("https://"))
            {
                return address;
            }
            else
            {
                return address.Insert(0, "https://");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(App.NormalizeUrl("google.com")); /*https://google.com*/
            Console.WriteLine(App.NormalizeUrl("https://ai.fi")); /*https://ai.fi*/
            Console.ReadKey();
        }
    }
}