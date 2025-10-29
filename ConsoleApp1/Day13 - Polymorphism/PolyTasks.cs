using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Day13___Polymorphism
{
    // Animal class - task 1
    public class Animal
    {
        public virtual void Sound() { }
    }

    public class Bird : Animal
    {
        public override void Sound() {
            Console.WriteLine("Kookoo");
        }
    }

    public class Cat : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Meow");
        }
    }


    // Task 2 - Vehicle - speedup
    public class Vehicle
    {
        int speed;

        public virtual void speedUp () { }
    }


    public class Car : Vehicle
    {
        int speed = 200;

        public override void speedUp()
        {
            Console.Write($"Speed of car increased from {this.speed}km/h to ");
            this.speed += 50;
            Console.WriteLine($"{this.speed}km/h");
        }
    }

    public class Bicycle : Vehicle
    {
        int speed = 10;

        public override void speedUp()
        {
            Console.Write($"Speed of bicycle increased from {this.speed}km/h to ");
            this.speed += 5;
            Console.WriteLine($"{this.speed}km/h");
        }
    }


    // Task 3 - Bank account

    enum AccountType
    {
        SavingsAccount,
        CheckingAccount
    }

    class Account
    {
        protected int balance = 0;
        protected AccountType type;
        protected int withdrawlLimitPerDay = 50000;
        protected int withdrawFee = 49;
        
        public virtual void deposit(int amount) {
            Console.WriteLine($"> Deposited {amount} to AC.");
            this.balance += amount;
        }

        public virtual void withdraw(int amount) {
            if (amount > this.balance) {
                throw new Exception("! Insufficient Balance in AC");
            }

            if (amount > this.withdrawlLimitPerDay)
            {
                throw new Exception("! Transaction exceeds withdrawl limit per day.");
            }

            this.balance -= (amount + this.withdrawFee);
            Console.WriteLine($"> Withdrawn Rs.{amount}, Charges: Rs.{this.withdrawFee}         ||          Account Balance: {this.balance}");
        }

        public void GetBalance()
        {
            Console.WriteLine($"> Account Balance: {this.balance}");
        }

    }

    class SavingsAccount : Account
    {
        public SavingsAccount(int balance = 0) {
            this.balance = balance;
            this.type = AccountType.SavingsAccount;
        }

        public override void deposit(int amount)
        {
            base.deposit(amount);
        }

        public override void withdraw(int amount)
        {
            base.withdraw(amount);
        }

    }

    class CheckingAccount : Account
    {
        public CheckingAccount(int balance)
        {
            this.balance = balance;
            this.type = AccountType.CheckingAccount;
            this.withdrawFee = 99;
            this.withdrawlLimitPerDay = 100000;
        }

        public override void deposit(int amount)
        {
            base.deposit(amount);
        }

        public override void withdraw(int amount)
        {
            base.withdraw(amount);
        }

    }


    // Task 4 - Employee

    public class Employee
    {
        public virtual void CalculateSalary() { }
    }

    public class Manager : Employee
    {
        public override void CalculateSalary()
        {
            Console.WriteLine("Manager Salary: Rs.80,000/-");
        }
    }

    public class Programmer : Employee
    {
        public override void CalculateSalary()
        {
            Console.WriteLine("Programmer Salary: Rs.50,000/-");
        }
    }



    // Task 5 - Shapes
    public class Shape {
        public virtual double GetArea() {
            return 4;
        }
        public virtual double GetPerimeter() {
            return 4;
        }
    }

    public class Circle : Shape
    {
        int radius;

        public Circle(int radius) { this.radius = radius; }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * this.radius;
        }
    }

    public class Rectangle : Shape
    {
        int length;
        int breadth;

        public Rectangle(int length, int breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }

        public override double GetArea()
        {
            return this.length * this.breadth;
        }

        public override double GetPerimeter()
        {
            return 2 * (this.length + this.breadth);
        }
    }

    public class Triangle : Shape
    {
        int baseLength;
        int height;

        public Triangle(int baseLength, int height)
        {
            this.baseLength = baseLength;
            this.height = height;
        }

        public override double GetArea()
        {
            return (this.baseLength * this.height) / 2;
        }

        public override double GetPerimeter()
        {
            return this.baseLength + this.height;
        }
    }

}
