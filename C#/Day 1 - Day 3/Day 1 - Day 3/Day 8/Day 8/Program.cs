using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Day 8: Check if a given word is a palindrome.");

            string word = "alila";
            string reversed = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversed += word[i];
                //Console.WriteLine(reversed);
            }
            if(reversed == word)
            {
                Console.WriteLine(" Its palindrome");
            }
            else
            {
                Console.WriteLine(" Its not palindrome");
            }
        }
    }
}
