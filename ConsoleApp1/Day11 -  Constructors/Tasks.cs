using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Day_11____Constructors
{

    class Book
    {
        private string title;
        private string author;
        public Book()
        {
            this.title = "Unknown";
            this.author = "Unknown";
        }

        public void SetAuthor(string author)
        {
            this.author = author;
        }

        public void SetTitle(string title)
        {
            this.title = title;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Book Title: {this.title}, Written by {this.author}");
        }

    }

    class Student
    {
        public string name;
        private int age;
        private char grade;

        public Student(string name, int age, char grade)
        {
            this.name = name;
            this.age = age;
            this.grade = grade;
        }

        public void Display()
        {
            Console.WriteLine($"Student: {name}, Age: {age}, Grade: {grade}");
        }


    }

    enum AccountType
    {
        Savings,
        Current
    }

    class BankAccount
    {

        private int balance = 0;
        readonly AccountType accountType = AccountType.Savings;
        private int accountNumber = 0;

        public BankAccount(AccountType accountType = AccountType.Savings)
        {
            this.balance = 0;
            this.accountType = accountType;
            this.accountNumber = new Random().Next(1,99999);
        }

        public int Deposit(int amount)
        {
            Console.WriteLine($"Depositing Rs.{amount} to Acc {this.accountNumber}");
            this.balance += amount;
            return this.balance;
        }

        public int Withdraw(int amount)
        {
            if (this.balance < amount)
            {
                Console.WriteLine($"Withdrawl request failed for Rs.{amount}, Acc: {this.accountNumber}.");
                throw new Exception("Insufficient funds.");
            }

            Console.WriteLine($"Withdrawl Succeeded for Rs.{amount}, Acc: {this.accountNumber}");
            this.balance -= amount;
            return this.balance;
        } 

    }

    class Employee
    {

        string name;
        public int basicSalary;
        public double hra;
        public double da;

        public Employee(string name, int basicSalary)
        {
            this.name = name;
            this.basicSalary = basicSalary;
            this.hra = 0.2 * basicSalary;
            this.da = 0.1 * basicSalary;
        }

        public Employee()
        {
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetBaseSalary(int salary)
        {
            this.basicSalary = salary;
            this.hra = 0.2 * basicSalary;
            this.da = 0.1 * basicSalary;
        }

        public double CalculateGrossSalary()
        {
            return (this.basicSalary + this.hra + this.da);
        }
    }

    internal class Tasks
    {
        
        public static void start()
        {
            Book b = new();
            b.SetTitle("1984");
            b.SetAuthor("George Orwell");
            b.DisplayInfo();

            Console.Write("\n\nEnter student name: ");
            string name = Console.ReadLine();
            Console.Write("Enter student age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter student grade (a/b/c/d/e): ");
            char grade = Convert.ToChar(Console.ReadLine());

            Student s = new(name!, age, grade);
            s.Display();
            Student s2 = new("John", 18, 'A');
            s2.Display();


            //
            Console.Write("\n\nEnter employee name: ");
            name = Console.ReadLine();
            Console.Write("Enter employee basic salary: ");
            int salary = Convert.ToInt32(Console.ReadLine());

            Employee e = new();
            e.SetName(name);
            e.SetBaseSalary(salary);
            Console.WriteLine($"Employee {name} gets paid gross salary of {e.CalculateGrossSalary()} (Base: {e.basicSalary} + HRA (20%): {e.hra} + DA (10%): {e.da})");


        }

    }
}
