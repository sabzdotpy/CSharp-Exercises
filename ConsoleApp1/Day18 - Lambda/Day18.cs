using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Day18___Lambda
{

    class Student
    {
        public string? Name { get; set; }
        public int Marks { get; set; }
    }
    internal class Day18
    {
        public static void start()
        {

            Func<int, int> square = (x) => x * x;
            int sq = square(5);
            Console.WriteLine(sq);

            Action<string> greet = (name) => Console.WriteLine($"Greetings {name}");

            Predicate<int> isMajor = (age) => age >= 18;

            Predicate<int> isEven = (num) => num % 2 == 0;

            Action<int> printEvenOrOdd = (num) => Console.WriteLine((isEven(num)) ? $"{num} is even" : $"{num} is odd");

            printEvenOrOdd(2);

            Action<string> printLength = (name) => Console.WriteLine($"Length of name {name}: {name.Length}");

            printLength("Sabari");

            List<int> nums = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var r = nums.Where(n => n % 2 == 0).Select(n => n).ToList();
            Console.WriteLine(string.Join(", ", r));

            string[] names = { "Indhu", "Ani", "Muthu", "Arun", "Isha" };

            List<string> fNames = names.Where((name) => name.StartsWith('A')).Select((name) => name.ToUpper()).ToList();
            Console.WriteLine(string.Join(", ", fNames));

            var squaredEvens = nums.Where(n => n % 2 == 0).Select(n => n * n).ToList();
            Console.WriteLine(string.Join(", ", squaredEvens));

            List<string> emails = ["sabari@yahoo.in", "john@gmail.com", "joe@gmail.com", "jane@outlook.com", "jose@gmail.com"];
            var gmails = emails.Where((email) => email.EndsWith("@gmail.com")).ToList();
            Console.WriteLine(string.Join(", ", gmails));

            List<Student> students = new List<Student>
            {
                new Student { Name = "Indhu", Marks = 85 },
                new Student { Name = "Ani", Marks = 45 },
                new Student { Name = "Muthu", Marks = 90 }
            };

            List<Student> toppers = students.Where(s => s.Marks > 80).ToList();
            foreach (Student s in toppers)
            {
                Console.Write($"{s.Name}({s.Marks}), ");
            }

            var xStudents = new[]
            {
                new { Id = 1, Name = "Arun", Marks = 85, Department = "IT" },
                new { Id = 2, Name = "Meena", Marks = 92, Department = "HR" },
                new { Id = 3, Name = "Kumar", Marks = 45, Department = "IT" },
                new { Id = 4, Name = "Priya", Marks = 78, Department = "Finance" },
                new { Id = 5, Name = "Ravi", Marks = 88, Department = "IT" }
            };

            var xToppers = xStudents.Where((s) => s.Marks > 80).OrderBy((s) => s.Marks);
            int topCount = xStudents.Count((s) => s.Marks > 80);

            Console.WriteLine($"\nTopper count: {topCount}");

            foreach (var s in xToppers)
            {
                Console.Write($"{s.Name}({s.Marks}), ");
            }


            // Task
            /*
             * Display all student names and their marks.
            3.	Find students who scored more than 80 marks.
            4.	Display all students ordered by marks (descending).
            5.	Find the total marks of all students combined.
            6.	Find the highest marks using LINQ (alternate to Aggregate):
            */

            Console.WriteLine("\n\n\n ================= \n");
            Console.WriteLine("1. Display all students and their marks");
            foreach (var s in xStudents)
            {
                Console.WriteLine($"{s.Name} - ({s.Marks} marks)");
            }
            Console.WriteLine("--------------------------");

            Console.WriteLine("2. Students who scored more than 80 marks");
            var top = xStudents.Where((s) => s.Marks > 80).ToList();
            Console.WriteLine(string.Join('\n', top));
            Console.WriteLine("--------------------------");


            Console.WriteLine("3. Display students ordered by marks (desc)");
            var ordered = xStudents.OrderByDescending(s => s.Marks).ToList();
            foreach (var s in ordered)
            {
                Console.WriteLine($"{s.Name} - {s.Marks} marks");
            }
            Console.WriteLine("--------------------------");


            Console.WriteLine("4. Total Marks of all students");
            var totalMarks = xStudents.Select((s) => s.Marks).Sum();
            Console.WriteLine($"Total Marks: {totalMarks}");
            Console.WriteLine("--------------------------");


            Console.WriteLine("5. Highest mark among all students marks");
            var maxMarks = xStudents.OrderByDescending((s) => s.Marks).First();
            Console.WriteLine($"Max Marks: {maxMarks}");
            Console.WriteLine("--------------------------");


            // Task 2 

            Console.WriteLine("\n\n===============================\n\n");

            var employees = new[]
            {
                new { Id = 1, Name = "Arun", Salary = 45000, Department = "IT" },
                new { Id = 2, Name = "Meena", Salary = 55000, Department = "HR" },
                new { Id = 3, Name = "Kumar", Salary = 30000, Department = "IT" },
                new { Id = 4, Name = "Priya", Salary = 60000, Department = "Finance" },
                new { Id = 5, Name = "Ravi", Salary = 40000, Department = "HR" }
            };

            // Display names of employees from HR department
            Console.WriteLine("All Employees in HR department");
            var hrEmployees = employees.Where((emp) => emp.Department == "HR").ToList();
            Console.WriteLine(string.Join('\n', hrEmployees));
            Console.WriteLine("--------------------------");

            Console.WriteLine("Employees who earn more than 45,000 Ordered by Salary");
            var more = employees.OrderByDescending((emp) => emp.Salary).Where((emp) => emp.Salary > 45000 ).ToList();
            Console.WriteLine(string.Join('\n', more));
            Console.WriteLine("--------------------------");

            Console.WriteLine("Printing name and department of employees ordered by Name");
            var nameAndDept = employees.OrderBy((emp) => emp.Name).Select((emp) => new { emp.Name, emp.Department }).ToList();
            Console.WriteLine(string.Join('\n', nameAndDept));
            Console.WriteLine("--------------------------");

            Console.WriteLine("Average Salary of All Employees: ");
            var averageSalary = employees.Select((emp) => emp.Salary).Average();
            Console.WriteLine(string.Join('\n', averageSalary));
            Console.WriteLine("--------------------------");

            Console.WriteLine("Employee with the Lowest Salary: ");
            var lowestSalaried = employees.Where((emp) => emp.Salary == (employees.OrderBy((emp) => emp.Salary).First()).Salary );
            Console.WriteLine(string.Join('\n', lowestSalaried));
            Console.WriteLine("--------------------------");


        }
    }
}