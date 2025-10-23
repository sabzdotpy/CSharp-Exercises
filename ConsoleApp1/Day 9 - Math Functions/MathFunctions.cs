using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MathFunctions
    {
        public static void IsValidEmail(string email)
        {
            bool isValid = (email.Contains("@") &&  email.Contains("."));
            Console.WriteLine(isValid ? "Email is Valid" : "Email is invalid.");
        }

        public static void CalculateElectricityBill(int units)
        {
            if (units <= 100)
            {
                Console.WriteLine("Your electricity charge is free.");
            }
            else if (units > 100 && units <= 500)
            {
                double perUnitCharge = 5.0;
                Console.WriteLine($"Your electricity charge is {units * perUnitCharge}.");
            }
            else if (units > 500 && units < 1000)
            {
                double perUnitCharge = 7.25;
                Console.WriteLine($"Your electricity charge is {units * perUnitCharge}.");
            }
            else
            {
                Console.WriteLine("You have crossed more than 1000 units, please contact electricity board.");
            }
        }

        public static void ConvertToFahranheit(double celsius)
        {
            if (!double.IsNaN(celsius))
            {
                Console.WriteLine("Temp is blank.");
            }

            // (0°C × 9/5) + 32 = 32°F
            double f = (celsius * (9 / 5)) + 32;
            Console.WriteLine($"{celsius}C is {f}F");

        }

        public static void ConvertToCelsius(double fahranheit)
        {
            if (!double.IsNaN(fahranheit))
            {
                Console.WriteLine("Temp is blank.");
            }

            // (32°F − 32) × 5/9 = 0°C
            double c = (fahranheit - 32) * (5/9);
            Console.WriteLine($"{fahranheit}F is {c}C");
        }

        public static void IsPalindrome(string text)
        {
            Console.WriteLine((text! == text.Reverse()) ? "Text is a palindrome." : "Text is not a palindrome.");
        }

        public static void IsPalindrome(int number)
        {
            int reversed = 0;
            int copy = number;
            while (copy > 0)
            {
                int last_digit = copy % 10;
                reversed = reversed * 10 + last_digit;
                copy = copy / 10;
            }
            Console.WriteLine( (number == reversed) ? "Number is a palindrome." : "Number is not a palindrome." );
        }

        public static void Area(int radius)
        {
            Console.WriteLine($"Area of circle with {radius} is {(Math.PI * Math.Pow(radius, 2))}");
        }

        public static void Area(int length, int breadth)
        {
            Console.WriteLine($"Area of rectangle is {length * breadth}");
        }

        public static void AreaTriangle(int Base, int height)
        {
            Console.WriteLine($"Area of triangle with base {Base} and height {height} is {(height * Base) / 2}");
        }

        public static void GetEvenNumbers(int[] nums)
        {
            List<int> evenNums = [];

            foreach (int num in nums)
            {
                if (num % 2 == 0) evenNums.Add(num);
            }

            Console.Write($"Even Numbers: [");
            foreach (int num in evenNums)
            {
                Console.Write($"{num},");
            }
            Console.WriteLine("]");
        }

        public static void FindPower(double baseNum, double exponent)
        {
            Console.WriteLine($"{baseNum}^{exponent} = {Math.Pow(baseNum, exponent)}");
        }

        public static void GetAbsolute(int num)
        {
            Console.WriteLine($"Absolute of {num} is {Math.Abs(num)}");
        }
        public static void FindMaxMin(int a, int b)
        {
            Console.WriteLine($"Minimum of {a} and {b} is {Math.Min(a,b)}");
            Console.WriteLine($"Maximum of {a} and {b} is {Math.Max(a, b)}");
        }
        public static void RoundValue(double num)
        {
            Console.WriteLine($"Round of {num} is {Math.Round(num)}");
        }
        public static void BMI(double weight, double height)
        {
            Console.WriteLine($"BMI of person with W: {weight} and H: {height} is { weight / Math.Pow(height, 2) }");
        }
        public static void GetDistance(double x1, double y1, double x2, double y2)
        {
            Console.WriteLine($"Distance between ({x1},{y1}) and ({x2},{y2}) is {Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2))}");
        }
        public static void ConvertTempWithRounding(double celsius)
        {
            double f = (celsius * (9 / 5)) + 32;
            Console.WriteLine($"{celsius}C is {f:2F}F");
        }

        public static void CalculateCompoundInterest(double principal, double rate, int time)
        {
            Console.WriteLine($"Compund interest after {time} years is: {principal * Math.Pow((1 + rate / 100), time) - principal}");
        }

        
        public static void RandomCircleAreaGenerator()
        {
            Random random = new Random();
            int r = random.Next(100);

            Area(r);
        }


        public static void FindQuadraticRoots(double a, double b, double c)
        {
            if (a == 0)
            {
                Console.WriteLine("Coefficient 'a' can't be 0 for a quadratic eqn.");
                return;
            }

            double discriminant = b * b - 4 * a * c;

            if (discriminant > 0)
            {
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine($"Two distinct real roots: {root1} and {root2}");
            }
            else if (discriminant == 0)
            {
                double root = -b / (2 * a);
                Console.WriteLine($"One real root: {root}");
            }
            else
            {
                double realPart = -b / (2 * a);
                double imaginaryPart = Math.Sqrt(-discriminant) / (2 * a);
                Console.WriteLine($"Complex roots: {realPart} + {imaginaryPart}i and {realPart} - {imaginaryPart}i");
            }
        }

        public static void FindLogs(double num)
        {
            Console.WriteLine($"Log of {num} is {Math.Log(num)}");
        }

        public static void ShowTrigValues(double angle)
        {
            double sinValue = Math.Sin(angle);
            double cosValue = Math.Cos(angle);
            double tanValue = Math.Tan(angle);

            Console.WriteLine($"Angle (radians): {angle}");
            Console.WriteLine($"Sin: {sinValue}");
            Console.WriteLine($"Cos: {cosValue}");
            Console.WriteLine($"Tan: {tanValue}");
        }

        public static void ShowRoundingComparison(double number)
        {
            double floorValue = Math.Floor(number);
            double ceilingValue = Math.Ceiling(number);
            double roundValue = Math.Round(number);

            Console.WriteLine($"Original Number: {number}");
            Console.WriteLine($"Math.Floor(): {floorValue}");
            Console.WriteLine($"Math.Ceiling(): {ceilingValue}");
            Console.WriteLine($"Math.Round(): {roundValue}");
        }

        public static void PopulationGrowth(double initial, double rate, int years)
        {
            double population = initial * Math.Exp(rate * years);
            Console.WriteLine($"Initial Population: {initial}");
            Console.WriteLine($"Growth Rate: {rate}");
            Console.WriteLine($"Years: {years}");
            Console.WriteLine($"Population after {years} years: {population}");
        }

    }
}
