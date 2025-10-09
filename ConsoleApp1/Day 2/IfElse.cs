using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class IfElse
    {
        public static void GreatestBetweenTwo(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine($"{a} is greater than {b}");
            }
            else if (a < b)
            {
                Console.WriteLine($"{b} is greater than {a}");
            }
            else
            {
                Console.WriteLine("Both numbers are equal.");
            }
        }

        public static void GreatestAmongThree(int a, int b, int c)
        {
            if (a >= b && a >= c)
            {
                Console.WriteLine($"{a} is the greatest among {a}, {b}, and {c}");
            }
            else if (b >= a && b >= c)
            {
                Console.WriteLine($"{b} is the greatest among {a}, {b}, and {c}");
            }
            else
            {
                Console.WriteLine($"{c} is the greatest among {a}, {b}, and {c}");
            }
        }

        public static void IsEven(Int64 number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is an even number.");
            }
            else
            {
                Console.WriteLine($"{number} is an odd number.");
            }
        }

        public static void IsLeapYear(int year)
        {
            // Leap year condition: Must be divisible by 4, AND not divisible by 100 , UNLESS also divisible by 400
            if ( (year % 4 == 0) && (year % 100 != 0 || year % 400 == 0) )
            {
                Console.WriteLine($"{year} is a leap year.");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year.");
            }
        }

        public static void IsNumberPositive(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"{number} is positive.");
            }
            else
            {
                Console.WriteLine($"{number} is negative.");
            }
        }

        public static void WeirdNProgram(int m)
        {
            if (m > 0)
            {
                Console.WriteLine($"N is 1 since m is more than 0.");
            }
            else if (m < 0)
            {
                Console.WriteLine($"N is -1 since m is less than 0.");
            }
            else
            {
                Console.WriteLine($"N is 0 since m is equal to 0.");
            }
        }

        public static void WhichQuadrant(int x, int y)
        {
            if (x > 0 && y > 0)
            {
                Console.WriteLine($"({x},{y}) is in Quadrant 1.");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine($"({x},{y}) is in Quadrant 2.");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine($"({x},{y}) is in Quadrant 3.");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine($"({x},{y}) is in Quadrant 4.");
            }
            else if (x == 0 && y != 0)
            {
                Console.WriteLine($"({x},{y}) is on the Y axis.");
            }
            else if (x != 0 && y == 0)
            {
                Console.WriteLine($"({x},{y}) is on the X axis.");
            }
            else
            {
                Console.WriteLine($"({x},{y}) is at the origin.");

            }
        }

        public static void ElectricityBill(int units)
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

        public static void GradeCalculator(double[] marksOfSubjects)
        {
            double total = 0;
            foreach (double mark in marksOfSubjects)
            {
                total += mark;
            }

            switch (total)
            {
                case double n when n >= 450 && n <= 500:
                    Console.WriteLine($"You got Grade A with total marks: {total}");
                    break;

                case double n when n >= 400 && n < 450:
                    Console.WriteLine($"You got Grade B with total marks: {total}");
                    break;

                 case double n when n >= 350 && n < 400:
                    Console.WriteLine($"You got Grade C with total marks: {total}");
                    break;

                case double n when n >= 300 && n < 350:
                    Console.WriteLine($"You got Grade D with total marks: {total}");
                    break;
                
                case double n when n >= 250 && n < 300:
                    Console.WriteLine($"You got Grade E with total marks: {total}");
                    break;

                case double n when n >= 0 && n < 250:
                    Console.WriteLine($"You got Grade F with total marks: {total}");
                    break;
                default:
                    Console.WriteLine("Invalid total marks.");
                    break;
            }

        }

        public static void TemperatureFeedback(double temp)
        {
            switch (temp)
            {
                case double n when n >= 40:
                    Console.WriteLine("Very Hot.");
                    break;

                case double n when n >= 30 && n < 40:
                    Console.WriteLine("Hot.");
                    break;

                case double n when n >= 20 && n < 30:
                    Console.WriteLine("Normal.");
                    break;

                case double n when n >= 10 && n < 20:
                    Console.WriteLine("Cold.");
                    break;

                case double n when n >= 0 && n < 10:
                    Console.WriteLine("Very Cold.");
                    break;

                default:
                    Console.WriteLine("Freezing.");
                    break;
            }
        }

        public static void IsMailAndUsernameValid(string email, string username)
        {
            string validEmailPattern = @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}";
            string validUsernamePattern = @"^[a-zA-Z0-9._-]{3,16}$";

            if (Regex.IsMatch(email.Trim(), validEmailPattern))
            {
                Console.WriteLine("Email is valid.");
            }
            else
            {
                Console.WriteLine("Email is not valid.");
            }

            if (Regex.IsMatch(username, validUsernamePattern))
            {
                Console.WriteLine("Username is valid.");
            }
            else
            {
                Console.WriteLine("Username is not valid.");
            }
        }

        public static void IsEligibleForJob(int aptitudeMarks, int gdMarks, int technicalMarks, int hrMarks)
        {
            if (aptitudeMarks >= 85 && gdMarks >= 90 && technicalMarks >= 80 && hrMarks >= 95)
            {
                Console.WriteLine("You are eligible for the job.");
            }
            else
            {
                Console.WriteLine("You are not eligible for the job.");
            }
        }

        public static void IsRectangleSquare(int length, int breadth)
        {
            if (length == breadth)
            {
                Console.WriteLine("The rectangle is a square.");
            }
            else
            {
                Console.WriteLine("The rectangle is not a square.");
            }
        } 

        public static void DiscountPercentage(int purchaseQuantity, int unitCost)
        {
            int totalCost = unitCost * purchaseQuantity;
            Console.WriteLine($"Purchase Quantity: ${purchaseQuantity}, Unit Cost: ${unitCost}, Total Cost: ${totalCost}");

            if (purchaseQuantity > 1000)
            {
                double discount = 10.0;
                double discountedPrice = totalCost - (totalCost * discount / 100);
                Console.WriteLine($"You got a discount of {discount}%. Your total cost after discount is {discountedPrice}.");
            }
            else
            {
                Console.WriteLine($"Your total cost is {totalCost}. No discount applicable.");
            }
        }

        public static void NetBonus(int salary, int yearsOfService)
        {
            if (yearsOfService > 5)
            {
                int bonus = 5;
                int net = salary + (salary * bonus / 100);
                Console.WriteLine($"Your salary with bonus is {net}.");
                return;
            }
            Console.WriteLine($"Your salary is {salary}.");
        }

        public static void IsAllowedForExam(int classesHeld, int classesAttended)
        {
            int attendanceThreshold = 75;
            double attendancePercentage = (classesAttended / (double)classesHeld) * 100;

            Console.Write($"Your attendance percentage is {attendancePercentage}%, ");

            if (attendancePercentage > attendanceThreshold)
            {
                Console.WriteLine("you are allowed to sit in the exam.");
            }
            else
            {
                Console.WriteLine("you are not allowed to sit in the exam.");
            }
        }

        public static void weekDayName(int weekDay)
        {
            switch (weekDay)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid day number. Please enter a number between 1 and 7.");
                    break;
            }
        }
    }
}
