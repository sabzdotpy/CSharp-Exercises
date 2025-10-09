using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Day2
    {
        public static void start()
        {
            Console.WriteLine("Hello Day 2!");
            Console.WriteLine("");

            Console.WriteLine("1. Greatest between 2 numbers:");
            Console.Write("Enter number 1: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number 2: ");
            int b = Convert.ToInt32(Console.ReadLine());

            IfElse.GreatestBetweenTwo(a, b);
            
            //
            Console.WriteLine("");

            Console.WriteLine("2. Greatest between 3 numbers:");
            Console.Write("Enter number 1: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number 2: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number 3: ");
            int z = Convert.ToInt32(Console.ReadLine());

            IfElse.GreatestAmongThree(x, y, z);

            //
            Console.WriteLine("");

            Console.WriteLine("3. Check whether a number is even or odd:");
            Console.Write("Enter a number: ");
            Int64 n = Convert.ToInt64(Console.ReadLine());

            IfElse.IsEven(n);

            //
            Console.WriteLine("");
            Console.WriteLine("4. Check whether a year is leap year or not:");
            Console.Write("Enter a year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            IfElse.IsLeapYear(year);

            //
            Console.WriteLine("");

            Console.WriteLine("5. Check if given number is positive or not: ");
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            IfElse.IsNumberPositive(num);

            //
            Console.WriteLine("");

            Console.WriteLine("6. N M Program");
            Console.Write("Enter value for M: ");
            int m = Convert.ToInt32(Console.ReadLine());

            IfElse.WeirdNProgram(m);

            //
            Console.WriteLine("");

            Console.WriteLine("7. Find quadrant of a coordinate:");
            Console.Write("Enter X: ");
            int X = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Y: ");
            int Y = Convert.ToInt32(Console.ReadLine());

            IfElse.WhichQuadrant(X, Y);

            //
            Console.WriteLine("");

            Console.WriteLine("8. Electricity Bill: ");
            Console.Write("Enter units used: ");
            int units = Convert.ToInt32(Console.ReadLine());

            IfElse.ElectricityBill(units);

            //
            Console.WriteLine("");

            Console.WriteLine("9. Calculate Grade: ");
            Console.Write("Enter marks obtained in Tamil: ");
            int tamil = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter marks obtained in English: ");
            int english = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter marks obtained in Maths: ");
            int math = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter marks obtained in Science: ");
            int science = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter marks obtained in Social Science: ");
            int social = Convert.ToInt32(Console.ReadLine());
            
            double[] marks = { tamil, english, math, science, social };
            IfElse.GradeCalculator(marks);

            //
            Console.WriteLine("");

            Console.WriteLine("10. Temperature Feedback: ");
            Console.Write("Enter the temperature: ");
            int temp = Convert.ToInt32(Console.ReadLine());

            IfElse.TemperatureFeedback(temp);

            //
            Console.WriteLine("");

            Console.WriteLine("11. Email and Username Checker: ");
            Console.Write("Enter your email: ");
            string email = Console.ReadLine();
            Console.Write("Enter your username: ");
            string username = Console.ReadLine();

            IfElse.IsMailAndUsernameValid(email, username);

            //
            Console.WriteLine("");

            Console.WriteLine("12. Job Eligibility: ");
            Console.Write("Enter marks obtained in Aptitude Round: ");
            int aptitude = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter marks obtained in GD Round: ");
            int gd = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter marks obtained in Technical Round: ");
            int technical = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter marks obtained in HR Round: ");
            int hr = Convert.ToInt32(Console.ReadLine());

            IfElse.IsEligibleForJob(aptitude, gd, technical, hr);

            //
            Console.WriteLine("");

            Console.WriteLine("13. Is Rectaingle Square>?");
            Console.Write("Enter length: ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter breadth: ");
            int breadth = Convert.ToInt32(Console.ReadLine());

            IfElse.IsRectangleSquare(length, breadth);

            //
            Console.WriteLine("");

            Console.WriteLine("14. Discount Calculator: ");
            Console.Write("Enter the unit price: ");
            int unitPrice = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            IfElse.DiscountPercentage(quantity, unitPrice);

            //
            Console.WriteLine("");

            Console.WriteLine("15. Bonus Calculator: ");
            Console.Write("Enter the salary: ");
            int salary = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the years of service: ");
            int years = Convert.ToInt32(Console.ReadLine());

            IfElse.NetBonus(salary, years);

            //
            Console.WriteLine("");

            Console.WriteLine("16. Allowed For Exam?");
            Console.Write("Enter total number of classes held: ");
            int totalClasses = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter total number of classes attended: ");
            int attendedClasses = Convert.ToInt32(Console.ReadLine());

            IfElse.IsAllowedForExam(totalClasses, attendedClasses);

            //
            Console.WriteLine("");

            Console.WriteLine("17. Print Weekday Name: ");
            Console.Write("Enter a number (1-7): ");
            int day = Convert.ToInt32(Console.ReadLine());

            IfElse.weekDayName(day);

            Console.WriteLine("\n\nEnd of Day 2.");
        }
    }
}
