// A Hellow World program in C#
/* Test Comment
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("What is your name? ");
            var name = Console.ReadLine();
            var date = DateTime.Now;

            Console.WriteLine($"\nHello, {name}, on {date:d} at {date:t}!");
            Console.Write("\nPress Any Key to Exit...");

            Console.ReadKey(true);
        }
    }
}
