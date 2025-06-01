using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4___Day6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Day 4 - Day6 (Modify or expand this task for more complexity.)");
            Console.WriteLine(" ---------------------------------------------------------------");

            Console.WriteLine("\n Day 4: Write a program that determines the largest of three user-input numbers.");

            int num1, num2, num3;

            Console.Write("\n Enter first number  : ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("\n Enter second number : ");
            num2 = int.Parse(Console.ReadLine());

            Console.Write("\n Enter third number  : ");
            num3 = int.Parse(Console.ReadLine());

            int max = Math.Max(num1,(Math.Max(num2,num3)));
            int min = Math.Min(num1,(Math.Max(num2, num3)));

            if (max == num1) Console.WriteLine("\n Highest Number : " + num1);
            if (max == num2) Console.WriteLine("\n Highest Number : " + num2);
            if (max == num3) Console.WriteLine("\n Highest Number : " + num3);
            if (min == num1) Console.WriteLine("\n Lowest Number  : " + num1);
            if (min == num2) Console.WriteLine("\n Lowest Number  : " + num2);
            if (min == num3) Console.WriteLine("\n Lowest Number  : " + num3);

            Console.WriteLine(" ---------------------------------------------------------------");

            Console.WriteLine("\n Day 5: Create a simple calculator that performs basic arithmetic operations.");

            Console.Write("\n Enter a number : ");
            float firstNum = float.Parse(Console.ReadLine());

            Console.Write("\n Choose a operator[+,-,*,/] : ");
            string ops = Console.ReadLine();

            Console.Write("\n Enter a number : ");
            float secondNum = float.Parse(Console.ReadLine());

            float total = 0;

            switch (ops)
            {
                case "+":
                    total = firstNum + secondNum;
                    break;

                case "-":
                    total = firstNum - secondNum;
                    break;

                case "*":
                    total = firstNum * secondNum;
                    break;

                case "/":
                    total = firstNum / secondNum;
                    break;
            }
            Console.WriteLine("Total : " + total);

            Console.WriteLine(" ---------------------------------------------------------------");

            Console.WriteLine("\n Day 6: Write a program that prints numbers from 1 to 100 using a loop.");

            int number = 100;

            for(int i = 1; i <= number; i++)
            {
                Console.Write(" " + i + " ");
            }
            Console.ReadKey();
        }
    }
}
