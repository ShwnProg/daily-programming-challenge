using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Day 10: Display the multiplication table of a number entered by the user.");

            Console.Write(" Enter a number : ");
            int num = int.Parse(Console.ReadLine());

            int ans;

            for(int i = num; i <= num; i++)
            {
                //Console.WriteLine(i);
                for (int j = 1; j <= 10; j++)
                {
                    ans = i * j;
                    Console.WriteLine(i + " * " + j + " = " + ans);
                }

            }
        }
    }
}
