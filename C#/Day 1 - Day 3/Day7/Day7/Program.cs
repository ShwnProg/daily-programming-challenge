using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Day 7: Count the number of vowels in a string input by the user.");

            Console.Write("\n Input here : ");
            string input = Console.ReadLine();

            char[] Chars = input.ToCharArray();

            int vowels = 0;
            for(int i = 0; i < Chars.Length; i++)
            {
                if (Chars[i] == 'a' || Chars[i] == 'e' || Chars[i] == 'i' || Chars[i] == 'o' || Chars[i] == 'u')
                {
                    vowels++;
                }
            }
            //input = Chars.ToString();

            Console.WriteLine("\n " + input + " has a " + vowels + " Vowels");
        }
    }
}
