using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Expando;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day_1___Day_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Day 1 - Day 3 daily task (Modify or expand this task for more complexity).");
            Console.WriteLine(" -----------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green; // optional
            Console.WriteLine("\n Day 1: Create a C# program that displays 'Hello, World!'.");
            Console.ResetColor();
            Console.WriteLine("\n Hello!\n World!");

            Console.WriteLine(" -----------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n Day 2: Write a program that asks the user to input their name and then greets them by name.");
            Console.ResetColor();

            string name;

            Console.Write("\n Please enter your name : ");
            name = Console.ReadLine();

            Console.WriteLine("\n Hello \"" + name + "\" nice to meet youuu!");

            Console.WriteLine(" -----------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n Day 3: Create a program that checks whether a number is even or odd.");
            Console.ResetColor();

            int num = 34;

            if(num % 2 == 0)
            {
                Console.WriteLine("\n \"" + num + "\" is a even number.");
            }
            else
            {
                Console.WriteLine("\n \"" + num + "\" is a odd number.");

            }

        }
    }
}
