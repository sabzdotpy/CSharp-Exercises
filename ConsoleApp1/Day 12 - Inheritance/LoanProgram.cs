using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Day_12___Inheritance
{

    class Human
    {
        int salary;
        int loanAmount = 5000;
        int rentAmount = 3000;
        int personalSpent = 4000;

        public Human()
        {
            Console.Write("Enter salary: ");
            this.salary = Convert.ToInt32(Console.ReadLine());
            this.PrintSalary();
        }

        public void Loan()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Paid Rs.{loanAmount} for loan");
            this.salary -= loanAmount;
            this.PrintSalary();
        }

        public void Rent()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Paid Rs.{rentAmount} for rent");
            this.salary -= rentAmount;
            this.PrintSalary();

        }

        public void PersonalSpent()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Spent Rs.{personalSpent} for personal.");
            this.salary -= personalSpent;
            this.PrintSalary();

        }

        public void PrintSalary()
        {
            Console.WriteLine($"Bank Balance: {this.salary}");
        }
    }
}
