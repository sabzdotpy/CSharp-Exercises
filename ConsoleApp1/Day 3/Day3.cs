using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Day3
    {
        public static void start()
        {

            Console.WriteLine("1/6 Sum of numbers from 1 to n");
            Console.Write("Enter a number: ");
            int target = Convert.ToInt32(Console.ReadLine());
            Loops.SumOfNumbers(target);

            Console.WriteLine("--------------------");
            Console.WriteLine("2/6 Even Numbers in the range 1 to 100 using Do While Loop");
            Loops.EvenNumbersUsingDoWhile();
            Console.WriteLine();

            Console.WriteLine("--------------------");
            Console.WriteLine("3/6 Sum and Count of Even Numbers from 1 to n");
            Console.Write("Enter a number: ");
            target = Convert.ToInt32(Console.ReadLine());
            Loops.SumAndCountOfEvenNumbers(target);

            Console.WriteLine("--------------------");
            Console.WriteLine("4/6 Multiplication Table from 1 to n");
            Console.Write("Enter a number: ");
            int targetNumber = Convert.ToInt32(Console.ReadLine());
            Loops.MultiplicationTable(targetNumber);

            Console.WriteLine("--------------------");
            Console.WriteLine("5/6 Sum of digits of a number");
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Loops.SumOfDigits(number);

            Console.WriteLine("--------------------");
            Console.WriteLine("6/6 Is word palindrome?");
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();
            Loops.Palindrome(word);

            Console.WriteLine("--------------------");
            Console.WriteLine("Part 2: \n\n");


            Console.WriteLine("1/6 Spy Number: ");
            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());
            Loops.SpyNumber(number);

            Console.WriteLine("--------------------");
            Console.WriteLine("2/6 Strong Number: ");
            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());
            Loops.StrongNumber(number);

            Console.WriteLine("--------------------");
            Console.WriteLine("3/6 Perfect Number: ");
            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());
            Loops.PerfectNumber(number);

            Console.WriteLine("--------------------");
            Console.WriteLine("4/6 Harshad Number: ");
            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());
            Loops.HarshadNumber(number);

            Console.WriteLine("--------------------");
            Console.WriteLine("5/6 Neon Number: ");
            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());
            Loops.NeonNumber(number);

            Console.WriteLine("--------------------");
            Console.WriteLine("6/6 Automorphic Number (ends with): ");
            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());
            Loops.AutomorphicNumber(number);

            Console.WriteLine("End of Day 3 Programs");

        }
    }
}
