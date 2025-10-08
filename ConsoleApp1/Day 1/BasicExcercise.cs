using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BasicExcercise
    {
        public static void EvenNumberCheck(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("The given number is even.");
            }
            else
            {
                Console.WriteLine("The given number is odd.");
            }
        }

        public static void FindGrade(int grade)
        {
            if (grade >= 90)
            {
                Console.WriteLine("You got Grade A!");
            }
            else if (grade >= 80)
            {
                Console.WriteLine("Grade: B");
            }
            else if (grade >= 70)
            {
                Console.WriteLine("Grade: C");
            }
            else if (grade >= 60)
            {
                Console.WriteLine("Grade: D");
            }
            else
            {
                Console.WriteLine("You got grade F");
            }
        }

        public static void SimpleCalc(int a, int b, char op)
        {
            switch (op)
            {
                case '+':
                    Console.WriteLine($"{a} {op} {b} = {a + b}");
                    break;
                case '-':
                    Console.WriteLine($"{a} {op} {b} = {a - b}");
                    break;
                case '*':
                    Console.WriteLine($"{a} {op} {b} = {a * b}");
                    break;
                case '/':
                    if (b != 0)
                    {
                        Console.WriteLine($"{a} {op} {b} = {a / b}");
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero..");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation. Please only type +, -, *, or /.");
                    break;
            }
        }

        public static void FindDay(int dayNum)
        {
            switch (dayNum)
            {
                case 1:
                    Console.WriteLine("The day is Monday");
                    break;
                case 2:
                    Console.WriteLine("The day is Tuesday");
                    break;
                case 3:
                    Console.WriteLine("The day is Wednesday");
                    break;
                case 4:
                    Console.WriteLine("The day is Thursday");
                    break;
                case 5:
                    Console.WriteLine("The day is Friday");
                    break;
                case 6:
                    Console.WriteLine("The day is Saturday");
                    break;
                case 7:
                    Console.WriteLine("The day is Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid day number was tpyed, only 1 to 7 allowed...");
                    break;
            }
        }
    }
}
