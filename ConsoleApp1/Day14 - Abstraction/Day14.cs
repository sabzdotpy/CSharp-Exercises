using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Day_14___Abstraction
{
    internal class Day14
    {
        public static void start()
        {
            //IShape circle = ShapeFactory.GetShape("circle");
            //circle.PrintName();
            //circle.Draw();

            //IShape sq = ShapeFactory.GetShape("square");
            //sq.PrintName();
            //sq.Draw();

            //Console.WriteLine("\n\n--------------------\n\n");

            //University uni = UniversityFactory.GetUniversity("harvard");
            //uni.SubmitApplication("Sabari", 98, 99);

            Console.WriteLine("=== University Admission System ===");

            Console.Write("Enter your name: ");
            string studentName = Console.ReadLine();

            Console.Write("Enter your total marks (0-100): ");
            int marks = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your interview score (0-100): ");
            int interviewScore = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter university name (harvard / stanford): ");
            string uniName = Console.ReadLine().ToLower();

            try
            {
                University university = UniversityFactory.GetUniversity(uniName);
                Console.WriteLine($"\nProcessing application for {studentName} at {uniName.ToUpper()}...\n");
                university.SubmitApplication(studentName!, marks, interviewScore);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine("\n=== End of Admission Process ===");



            Console.WriteLine("\n\n=== Factory Vehicle Production System ===");

            Console.Write("Enter vehicle type (car / bike / truck): ");
            string vehicleType = Console.ReadLine().ToLower();

            try
            {
                FactoryVehicle vehicle = VehicleFactory.GetVehicle(vehicleType);
                Console.WriteLine($"\n--- Starting {vehicleType.ToUpper()} Production Process ---\n");

                Console.WriteLine("Step 1: Assembling Vehicle...");
                vehicle.Assemble();

                Console.WriteLine("\nStep 2: Performing Test Drive...");
                vehicle.TestDrive(100, 20);

                Console.WriteLine("\nStep 3: Delivering Vehicle to Customer...");
                vehicle.Deliver(50000, 19);

                Console.WriteLine($"\n--- {vehicleType.ToUpper()} Production Completed Successfully ---");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine("\n=== End of Process ===");

            Console.WriteLine("\n\n=== Loan Processing System ===");

            Console.Write("Enter applicant name: ");
            string applicantName = Console.ReadLine();

            Console.Write("Enter loan type (home / car / education): ");
            string loanType = Console.ReadLine().ToLower();

            Console.Write("Enter loan amount: ");
            double loanAmount = Convert.ToDouble(Console.ReadLine());

            try
            {
                Loan loan = LoanFactory.GetLoan(applicantName, loanType);

                Console.WriteLine($"\nProcessing {loanType.ToUpper()} loan for {applicantName}...\n");

                if (loan.VerifyDocuments(applicantName))
                {
                    Console.WriteLine("Documents verified successfully.");
                }
                else
                {
                    Console.WriteLine("Document verification failed.");
                    return;
                }

                if (loan.ApplyLoan(loanAmount))
                {
                    Console.WriteLine("Loan application submitted successfully.");
                }

                double total = loan.SanctionLoan(loanAmount);
                Console.WriteLine($"Loan sanctioned successfully. Total repayment amount: {loanAmount + total}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine("\n=== End of Loan Process ===");

        }
    }
}
