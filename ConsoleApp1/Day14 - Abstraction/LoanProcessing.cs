using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Day_14___Abstraction
{
    public abstract class Loan
    {
        public abstract bool ApplyLoan(double loanAmount);
        public abstract bool VerifyDocuments(string applicantName);
        public abstract double CalculateInterest(double loanAmount, double rate, int years);
        public abstract double SanctionLoan(double loanAmount);
    }

    public class HomeLoan : Loan
    {
        public override bool ApplyLoan(double loanAmount = 500000)
        {
            Console.WriteLine($"Applying home loan for amount {loanAmount}");
            return true;
        }

        public override bool VerifyDocuments(string applicantName)
        {
            Console.WriteLine($"{applicantName}'s documents were verified successfully for home loan.");
            return true;
        }

        public override double CalculateInterest(double loanAmount, double rate, int years)
        {
            return ((loanAmount * rate * years) / 100);
        }

        public override double SanctionLoan(double loanAmount)
        {
            double total = CalculateInterest(loanAmount, 8.5, 8);
            Console.WriteLine($"Total Loan Amount: Base ({loanAmount}) + 18% interest for 8 years = {total}");
            return total;
        }
    }


    public class CarLoan : Loan
    {
        public override bool ApplyLoan(double loanAmount = 500000)
        {
            Console.WriteLine($"Applying car loan for amount {loanAmount}");
            return true;
        }

        public override bool VerifyDocuments(string applicantName)
        {
            Console.WriteLine($"{applicantName}'s documents were verified successfully for car loan.");
            return true;
        }

        public override double CalculateInterest(double loanAmount, double rate, int years)
        {
            return ((loanAmount * rate * years) / 100);
        }

        public override double SanctionLoan(double loanAmount)
        {
            double total = CalculateInterest(loanAmount, 8.5, 3);
            Console.WriteLine($"Total Loan Amount: Base ({loanAmount}) + 18% interest for 5 years = {total}");
            return total;
        }
    }

    public class EducationLoan : Loan
    {
        public override bool ApplyLoan(double loanAmount = 500000)
        {
            Console.WriteLine($"Applying education loan for amount {loanAmount}");
            return true;
        }

        public override bool VerifyDocuments(string applicantName)
        {
            Console.WriteLine($"{applicantName}'s documents were verified successfully for education loan.");
            return true;
        }

        public override double CalculateInterest(double loanAmount, double rate, int years)
        {
            return ((loanAmount * rate * years) / 100);
        }

        public override double SanctionLoan(double loanAmount)
        {
            double total = CalculateInterest(loanAmount, 11, 4);
            Console.WriteLine($"Total Loan Amount: Base ({loanAmount}) + 11% interest for 4 years = {total}");
            return total;
        }
    }

    public class LoanFactory
    {
        public static Loan GetLoan(string applicantName, string type)
        {
            if (string.IsNullOrEmpty(applicantName))
            {
                throw new ArgumentNullException("Loan Applicant name is empty or null");
            }

            if (type == "home")
            {
                return new HomeLoan();
            }
            else if (type == "car")
            {
                return new CarLoan();
            }
            else if (type == "education")
            {
                return new EducationLoan();
            }
            else
            {
                throw new Exception("Invalid loan type. Only 'home', 'car', 'education' are allowed");
            }

        }
    }
}
