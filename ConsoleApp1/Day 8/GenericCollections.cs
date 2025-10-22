using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class GenericCollections
    {
        
        public static void Example()
        {
            ArrayList a = new ArrayList();
            a.Add(1);
            a.Add("a");
            a.Add(2);
            a.Add(false);
            a.Add(null);
        }

        public static void Task1()
        {
            Console.WriteLine("Task 1: Store Student Marks in List: ");
            List<int> a = [];

            Console.Write("Enter count of marks you're going to enter: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i =  0; i < n; i++)
            {
                Console.Write($"Enter Mark #{i + 1}: ");
                int mark = Convert.ToInt32(Console.ReadLine());
                a.Add(mark);
            }

            int average = a.Sum() / a.Count;
            a.Sort();

            Console.WriteLine($"Average Marks: {average} ");
            Console.WriteLine($"Highest Mark: {a.ElementAt(0)}, Lowest Mark: {a.ElementAt(a.Count - 1)}");
            int count = 0;
            for (int i = 0; i <  a.Count; i++)
            {
                if ( a.ElementAt(i) > average )
                {
                    count++;
                }
            }
            Console.WriteLine($"Count of students who scored above average: {count}");
        }

        public static void Task2()
        {
            Console.WriteLine("Task 2: Student Dictionary");
            Dictionary<int, string> names = [];

            Console.Write("Enter count of marks you're going to enter: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int ID = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter Name of Student #{i + 1}: ");
                string name = Console.ReadLine();
                names.Add(ID++, name!);
            }

            Console.WriteLine("Students List:");
            foreach (KeyValuePair<int, string> student in names)
            {
                Console.WriteLine($"{student.Key} - {student.Value}");
            }

            Console.WriteLine("Enter a student ID to remove and display: ");
            int toRemove = Convert.ToInt32(Console.ReadLine());

            if (!names.Remove(toRemove))
            {
                Console.WriteLine("The entered ID is not found in the list.");
            }

            Console.WriteLine($"Student with ID {toRemove} removed.");

            Console.WriteLine("Students List:");
            foreach (KeyValuePair<int, string> student in names)
            {
                Console.WriteLine($"{student.Key} - {student.Value}");
            }

        }

        public static void Task3()
        {
            Console.WriteLine("Task 3: Browser history");

            Stack<string> history = new Stack<string>();
            while (true)
            {
                Console.WriteLine("\n1. Visit Page\n2. Back\n3. Current Page\n4. Show History\n5. Exit");
                Console.Write("Enter choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter page URL: ");
                        string page = Console.ReadLine();
                        history.Push(page);
                        Console.WriteLine($"Visited: {page}");
                        break;

                    case "2":
                        if (history.Count > 0)
                        {
                            Console.WriteLine($"Went back from: {history.Pop()}");
                        }
                        else
                        {
                            Console.WriteLine("No pages to go back to.");
                        }
                        break;

                    case "3":
                        if (history.Count > 0)
                            Console.WriteLine($"Current page: {history.Peek()}");
                        else
                            Console.WriteLine("No pages in history.");
                        break;

                    case "4":
                        Console.WriteLine("History:");
                        if (history.Count == 0)
                            Console.WriteLine("No pages visited.");
                        else
                            foreach (var h in history)
                                Console.WriteLine(h);
                        break;

                    case "5":
                        return;

                    default:
                        Console.WriteLine("Invalid num entered.");
                        break;
                }
            }

        }

        public static void Task4()
        {
            Console.WriteLine("Task 2: Simulated Ticket Booking System");

            Queue<string> strings = new Queue<string>();
            Console.WriteLine("Adding customer 'Joe'");
            strings.Enqueue("Joe");
            Console.WriteLine("Adding customer 'John'");
            strings.Enqueue("John");
            Console.WriteLine("Adding customer 'Jane'");
            strings.Enqueue("Jane");
            Console.WriteLine("Adding customer 'Joan'");
            strings.Enqueue("Joan");
            Console.WriteLine("Adding customer 'Jill'");
            strings.Enqueue("Jill");

            Console.WriteLine("-------------");
            Console.WriteLine("Customer List: ");
            foreach (var name in strings)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("-------------");

            Console.WriteLine("Dequeuing first customer: ");
            Console.WriteLine(strings.Dequeue());

            Console.WriteLine("Remaining Customer List: ");
            foreach (var name in strings)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("-------------");
        }

        public static void Task5()
        {
            Console.WriteLine("Task 5: Duplicate Numbers using Hashset");

            HashSet<int> nums = [];

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter number ({i + 1}/10): ");
                int num = Convert.ToInt32(Console.ReadLine());
                nums.Add(num);
            }

            Console.WriteLine("-------------");
            Console.WriteLine("HashSet: ");
            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("-------------");

            Console.Write("Enter number to check if present in hashset: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine( nums.Contains(x) );

        }

        public static void Task6()
        {
            Console.WriteLine("Task 6: Student Marks Summary");

            Dictionary<int, List<int>> students = new Dictionary<int, List<int>>();

            students[1] = new List<int> { 99, 100, 90, 85, 88 };
            students[2] = new List<int> { 60, 34, 66, 72, 68 };
            students[3] = new List<int> { 95, 82, 92, 84, 23 };

            Console.WriteLine("Student Marks Summary\n");

            double totalAllMarks = 0;
            int totalCount = 0;
            int topStudentId = 0;
            int topStudentTotal = 0;

            foreach (var student in students)
            {
                int id = student.Key;
                List<int> marks = student.Value;
                int total = marks.Sum();
                double average = marks.Average();

                Console.WriteLine($"Student ID: {id}");
                Console.WriteLine($"Marks: {string.Join(", ", marks)}");
                Console.WriteLine($"Average: {average}");
                Console.WriteLine($"Total: {total}\n");

                if (total > topStudentTotal)
                {
                    topStudentTotal = total;
                    topStudentId = id;
                }

                totalAllMarks += marks.Sum();
                totalCount += marks.Count;
            }

            double overallAverage = totalAllMarks / totalCount;

            Console.WriteLine("Summary Results:");
            Console.WriteLine($"Student with Highest Total Marks: {topStudentId} ({topStudentTotal} marks)");
            Console.WriteLine($"Overall Average Marks of All Students: {overallAverage}");

        }

    }
}
