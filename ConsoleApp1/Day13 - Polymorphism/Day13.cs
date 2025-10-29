using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Day13___Polymorphism
{
    internal class Day13
    {
        public static void start()
        {
            // Task 1 - Animal Sounds
            Console.WriteLine("Task 1/5 - Animal Sounds");
            Animal bird = new Bird();
            Animal cat = new Cat();
            bird.Sound();
            cat.Sound();
            Console.WriteLine("====================");

            // Task 2 - Vehicle Speed Up
            Console.WriteLine("Task 2/5 - Vehicle Speed Up");
            Vehicle car = new Car();
            Vehicle bicycle = new Bicycle();
            car.speedUp();
            bicycle.speedUp();
            Console.WriteLine("====================");

            // Task 3 - Bank Accounts
            Console.WriteLine("Task 3/5 - Bank Accounts");
            Console.Write("Enter initial balance for Savings Account: ");
            int savingsBalance = Convert.ToInt32(Console.ReadLine());
            SavingsAccount savings = new SavingsAccount(savingsBalance);

            Console.Write("Enter amount to deposit in Savings Account: ");
            int depositAmt = Convert.ToInt32(Console.ReadLine());
            savings.deposit(depositAmt);

            Console.Write("Enter amount to withdraw from Savings Account: ");
            int withdrawAmt = Convert.ToInt32(Console.ReadLine());
            try
            {
                savings.withdraw(withdrawAmt);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            savings.GetBalance();

            Console.Write("Enter initial balance for Checking Account: ");
            int checkingBalance = Convert.ToInt32(Console.ReadLine());
            CheckingAccount checking = new CheckingAccount(checkingBalance);

            Console.Write("Enter amount to deposit in Checking Account: ");
            int depositAmt2 = Convert.ToInt32(Console.ReadLine());
            checking.deposit(depositAmt2);

            Console.Write("Enter amount to withdraw from Checking Account: ");
            int withdrawAmt2 = Convert.ToInt32(Console.ReadLine());
            try
            {
                checking.withdraw(withdrawAmt2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            checking.GetBalance();
            Console.WriteLine("====================");

            // Task 4 - Employee Salary Calculation
            Console.WriteLine("Task 4/5 - Employee Salary Calculation");
            Employee manager = new Manager();
            Employee programmer = new Programmer();
            manager.CalculateSalary();
            programmer.CalculateSalary();
            Console.WriteLine("====================");

            // Task 5 - Shapes
            Console.WriteLine("Task 5/5 - Shapes");
            Console.Write("Enter shape - Triangle(t), Rectangle(r), Circle (c): ");
            char choice = Convert.ToChar(Console.ReadLine());
            switch (choice)
            {
                case 'c':
                    Console.Write("Enter radius of circle: ");
                    int radius = Convert.ToInt32(Console.ReadLine());
                    Shape circle = new Circle(radius);
                    Console.WriteLine($"Circle Area: {circle.GetArea()}");
                    Console.WriteLine($"Circle Perimeter: {circle.GetPerimeter()}");
                    break;

                case 'r':
                    Console.Write("Enter length of rectangle: ");
                    int length = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter breadth of rectangle: ");
                    int breadth = Convert.ToInt32(Console.ReadLine());
                    Shape rectangle = new Rectangle(length, breadth);
                    Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");
                    Console.WriteLine($"Rectangle Perimeter: {rectangle.GetPerimeter()}");
                    break;

                case 't':
                    Console.Write("Enter base length of triangle: ");
                    int baseLength = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter height of triangle: ");
                    int height = Convert.ToInt32(Console.ReadLine());
                    Shape triangle = new Triangle(baseLength, height);
                    Console.WriteLine($"Triangle Area: {triangle.GetArea()}");
                    Console.WriteLine($"Triangle Perimeter: {triangle.GetPerimeter()}");
                    break;

                default:
                    Console.WriteLine("Invalid shape");
                    break;
            }


            Console.WriteLine("====================");
        }
    }
}
