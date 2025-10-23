using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Day9
    {
        public static void start()
        {
            Console.WriteLine("=== Day 9 ===\n");

            Console.WriteLine("Task 1/17 - Validate Email");
            Console.Write("Enter an email: ");
            string email = Console.ReadLine();
            MathFunctions.IsValidEmail(email);
            Console.WriteLine("---------------------------");

            Console.WriteLine("Task 2/17 - Electricity Bill Calculation");
            Console.Write("Enter electricity units: ");
            int units = int.Parse(Console.ReadLine());
            MathFunctions.CalculateElectricityBill(units);
            Console.WriteLine("---------------------------");

            Console.WriteLine("Task 3/17 - Convert Celsius to Fahrenheit");
            Console.Write("Enter temperature in Celsius: ");
            double celsius = double.Parse(Console.ReadLine());
            MathFunctions.ConvertToFahranheit(celsius);
            Console.WriteLine("---------------------------");

            Console.WriteLine("Task 4/17 - Convert Fahrenheit to Celsius");
            Console.Write("Enter temperature in Fahrenheit: ");
            double fahrenheit = double.Parse(Console.ReadLine());
            MathFunctions.ConvertToCelsius(fahrenheit);
            Console.WriteLine("---------------------------");

            Console.WriteLine("Task 5/17 - Check Palindrome (String)");
            Console.Write("Enter text: ");
            string text = Console.ReadLine();
            MathFunctions.IsPalindrome(text);
            Console.WriteLine("---------------------------");

            Console.WriteLine("Task 6/17 - Check Palindrome (Number)");
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            MathFunctions.IsPalindrome(number);
            Console.WriteLine("---------------------------");

            Console.WriteLine("Task 7/17 - Area of Circle");
            Console.Write("Enter radius: ");
            int radius = int.Parse(Console.ReadLine());
            MathFunctions.Area(radius);
            Console.WriteLine("---------------------------");

            Console.WriteLine("Task 8/17 - Area of Rectangle");
            Console.Write("Enter length: ");
            int length = int.Parse(Console.ReadLine());
            Console.Write("Enter breadth: ");
            int breadth = int.Parse(Console.ReadLine());
            MathFunctions.Area(length, breadth);
            Console.WriteLine("---------------------------");

            Console.WriteLine("Task 9/17 - Area of Triangle");
            Console.Write("Enter base: ");
            int baseVal = int.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            int height = int.Parse(Console.ReadLine());
            MathFunctions.AreaTriangle(baseVal, height);
            Console.WriteLine("---------------------------");

            Console.WriteLine("Task 10/17 - Filter Even Numbers");
            Console.Write("Enter numbers separated by space: ");
            int[] nums = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            MathFunctions.GetEvenNumbers(nums);
            Console.WriteLine("---------------------------");

            Console.WriteLine("Task 11/17 - Find Power");
            Console.Write("Enter base: ");
            double baseNum = double.Parse(Console.ReadLine());
            Console.Write("Enter exponent: ");
            double exponent = double.Parse(Console.ReadLine());
            MathFunctions.FindPower(baseNum, exponent);
            Console.WriteLine("---------------------------");

            Console.WriteLine("Task 12/17 - Absolute Value");
            Console.Write("Enter number: ");
            int absNum = int.Parse(Console.ReadLine());
            MathFunctions.GetAbsolute(absNum);
            Console.WriteLine("---------------------------");

            Console.WriteLine("Task 13/17 - Find Maximum and Minimum");
            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());
            MathFunctions.FindMaxMin(a, b);
            Console.WriteLine("---------------------------");

            Console.WriteLine("Task 14/17 - Rounding Techniques Comparison");
            Console.Write("Enter a decimal number: ");
            double roundNum = double.Parse(Console.ReadLine());
            MathFunctions.ShowRoundingComparison(roundNum);
            Console.WriteLine("---------------------------");

            Console.WriteLine("Task 15/17 - Find Quadratic Equation Roots");
            Console.Write("Enter coefficient a: ");
            double qa = double.Parse(Console.ReadLine());
            Console.Write("Enter coefficient b: ");
            double qb = double.Parse(Console.ReadLine());
            Console.Write("Enter coefficient c: ");
            double qc = double.Parse(Console.ReadLine());
            MathFunctions.FindQuadraticRoots(qa, qb, qc);
            Console.WriteLine("---------------------------");

            Console.WriteLine("Task 16/17 - Show Trigonometric Values");
            Console.Write("Enter angle in degrees: ");
            double angleDegrees = double.Parse(Console.ReadLine());
            double angleRadians = angleDegrees * Math.PI / 180;
            MathFunctions.ShowTrigValues(angleRadians);
            Console.WriteLine("---------------------------");

            Console.WriteLine("Task 17/17 - Exponential Population Growth");
            Console.Write("Enter initial population: ");
            double initial = double.Parse(Console.ReadLine());
            Console.Write("Enter growth rate: ");
            double rate = double.Parse(Console.ReadLine());
            Console.Write("Enter number of years: ");
            int years = int.Parse(Console.ReadLine());
            MathFunctions.PopulationGrowth(initial, rate, years);
            Console.WriteLine("---------------------------");



        }
    }
}
