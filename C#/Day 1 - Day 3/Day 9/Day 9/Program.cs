using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Day 9: Store names in an array and search for a specific name.");
            string[] info = { "Shawn", "Marl", "Amaya", "Juan" };

            string name = "Marl";
            bool found = false;
            for (int i = 0; i < info.Length; i++)
            {
                if(name == info[i])
                {
                    Console.WriteLine("Search Found");
                    found = true;
                    break;
                }
        
            }
            if (!found)
            {
                Console.WriteLine("Search not found");
            }
        }
    }
}
