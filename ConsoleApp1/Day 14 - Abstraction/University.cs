using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Day_14___Abstraction
{

    // Task 1 - University
    public abstract class University
    {
        public abstract bool SubmitApplication(string name, int marks, int interviewScore);
        public abstract bool VerifyDocuments(int marks);
        public abstract bool ConductInterviews(int interviewScore);
        public abstract bool AnnounceResults(int marks, int interviewScore);
    }

    public class Harvard : University
    {
        public override bool SubmitApplication(string name, int marks, int interviewScore)
        {
            Console.WriteLine($"{name} application sent to Harvard University.");
            if ( VerifyDocuments(marks) && ConductInterviews(interviewScore) && AnnounceResults(marks, interviewScore) )
            {
                Console.WriteLine("Student Status: Accepted to Harvard.");
                return true;
            }
            Console.WriteLine("Student Status: Rejected from Harvard.");
            return false;
        }

        public override bool VerifyDocuments(int marks)
        {
            return (marks > 90);
        }

        public override bool ConductInterviews(int interviewScore)
        {
            return (interviewScore > 1 && interviewScore < 100);
        }

        public override bool AnnounceResults(int marks, int interviewScore)
        {
            Console.WriteLine($"Total Marks According to Harvard Calculation: {marks + interviewScore}");
            return ((marks + interviewScore) > 150);
        }
    }

    public class Stanford : University
    {
        public override bool SubmitApplication(string name, int marks, int interviewScore)
        {
            Console.WriteLine($"{name} application sent to Stanford University.");
            if (VerifyDocuments(marks) && ConductInterviews(interviewScore) && AnnounceResults(marks, interviewScore))
            {
                Console.WriteLine("Student Status: Accepted to Stanford.");
                return true;
            }
            Console.WriteLine("Student Status: Rejected from Stanford.");
            return false;
        }

        public override bool VerifyDocuments(int marks)
        {
            return (marks > 90);
        }

        public override bool ConductInterviews(int interviewScore)
        {
            return (interviewScore > 1 && interviewScore < 100);
        }

        public override bool AnnounceResults(int marks, int interviewScore)
        {
            Console.WriteLine($"Total Marks According to Stanford Calculation: {marks + interviewScore}");
            return ((marks + interviewScore) > 150);
        }
    }

    public class UniversityFactory
    {
        public static University GetUniversity(string name)
        {
            if (name == "harvard") return new Harvard();
            else if (name == "stanford") return new Stanford();
            else throw new Exception("Invalid university name provided. Only 'harvard' and 'stanford' are supported");
        }
    }
}
