using ConsoleApp1.Day13___Polymorphism;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Day19___Group_By
{
    internal class Day19
    {
        public static void start()
        {

            Day19___Group_By.GrpByPrograms.Demo();

            return;

            Console.WriteLine("\n\n\n");
            List<int> numbers = new List<int> { 10, 15, -20, -25, -30, 34, -94, 4932, 2304, -354, -9834 };
            var groups = numbers.GroupBy(n => n > 0);
            foreach (var group in groups)
            {
                Console.WriteLine($"Key: {group.Key}");
                Console.WriteLine(group.Key ? "Positive Numbers:" : "Negative Numbers:");
                foreach (var val in group)
                {
                    Console.WriteLine($"  {val}");
                }
            }

            Console.WriteLine("\n\n\n---> Divisible by 3 \n\n");
            numbers = new List<int> { 12, 15, -20, -25, -30, 34, -94, 4932, 2304, -354, -9834 };
            groups = numbers.GroupBy(n => n % 3 == 0);
            foreach (var group in groups)
            {
                Console.WriteLine(group.Key ? "Divisible by 3:" : "Not Divisible by 3:");
                foreach (var val in group)
                {
                    Console.WriteLine($"  {val}");
                }
            }

            Console.WriteLine("\n\n=====================\n\n");
            var students = new[] {
                new { Name = "Ravi", Dept = "CSE" ,Age=23},
                new { Name = "Priya", Dept = "ECE",Age=15 },
                new { Name = "Kumar", Dept = "CSE" ,Age=20},
                new { Name = "Divya", Dept = "EEE" ,Age=23}
            };

            var byDepts = students.GroupBy((stu) => stu.Dept);

            foreach (var dept in byDepts)
            {
                Console.WriteLine($"Department: {dept.Key}");
                foreach (var stu in dept) {
                    Console.WriteLine($" - {stu.Name}");
                }
            }
            Console.WriteLine("\n\n=====================\n\n");

            var sales = new[]
            {
                new { Product = "Laptop", Region = "North", Amount = 50000 },
                new { Product = "Mobile", Region = "South", Amount = 30000 },
                new { Product = "Laptop", Region = "East",  Amount = 45000 },
                new { Product = "Tablet", Region = "North", Amount = 20000 },
                new { Product = "Mobile", Region = "West",  Amount = 25000 }
            };


            /*
             * 1.Group total sales by Product and display each product with its total amount.
             * 2. Group total sales by Region and count how many products were sold per region.Student Marks — Group by Subject
            */

            var ordered = sales.OrderBy(s => s.Amount).Last();
            Console.WriteLine($"Number of sales records: {sales.Length}");
            Console.WriteLine($"Product with highest amount price: {ordered.Product} - Rs.{ordered.Amount}");

            var distinct = sales.Select((p) => p.Product).Distinct().ToList();
            Console.Write("Distinct Products: ");
            Console.WriteLine(string.Join(", ", distinct));
            Console.WriteLine("\n\n-----------------------------\n\n");

            var byProduct = sales.GroupBy((sale) => sale.Product);

            foreach (var productGroup in byProduct)
            {
                Console.Write($"Product: {productGroup.Key} ({productGroup.Count()}x), Total = ");
                int sum = 0;

                foreach (var product in productGroup)
                {
                    sum += product.Amount;
                }
                Console.WriteLine(sum);
            }

            Console.WriteLine("\n---------------------------------------------\n");

            var byRegion = sales.GroupBy((sale) => sale.Region);
            foreach (var productRegion in byRegion)
            {
                Console.WriteLine($"Region: {productRegion.Key}, Total Products Sold = {productRegion.Count()}");
                foreach (var product in productRegion)
                {
                    Console.WriteLine($"  - {product.Product}");
                }
            }


            var marks = new[]
            {
                new { Name = "Ravi", Subject = "Maths", Marks = 85 },
                new { Name = "Priya", Subject = "Science", Marks = 90 },
                new { Name = "Kumar", Subject = "Maths", Marks = 70 },
                new { Name = "Divya", Subject = "Science", Marks = 88 },
                new { Name = "Arun", Subject = "English", Marks = 95 }
            };

            // Group by Subject

            Console.WriteLine("\n\n-------------------------------\n");

            var bySub = marks.GroupBy((m) => m.Subject);

            foreach (var subGroup in bySub)
            {
                Console.WriteLine($"{subGroup.Key}: ");
                foreach (var sub in subGroup)
                {
                    Console.WriteLine($"  {sub.Name} - {sub.Marks}");
                }
                Console.WriteLine("----------------------");
            }

            Console.WriteLine("\n\n-------------------------------\n\n");

            var attendance = new[]
            {
                new { Name = "Ravi", Grade = "A", DaysPresent = 25 },
                new { Name = "Priya", Grade = "B", DaysPresent = 26 },
                new { Name = "Kumar", Grade = "A", DaysPresent = 26 },
                new { Name = "Divya", Grade = "C", DaysPresent = 18 }
            };

            var marksOrdered = attendance.OrderByDescending((x) => x.DaysPresent).First();
            Console.WriteLine($"{marksOrdered.Name} has attended the most number of days ({marksOrdered.DaysPresent} days).\n");

            // grade should be a and percentage is 25.
            var matchedCandidate = attendance.Where((c) => c.Grade == "A" && c.DaysPresent == 25).ToList();
            Console.WriteLine($"{matchedCandidate[0].Name} has matched both conditions, Grade is A and Days present is 25.\n");


            // group by date
            var groupByDate = attendance.GroupBy((c) => c.DaysPresent).ToList();
            foreach (var dateGroup in groupByDate)
            {
                Console.WriteLine($"{dateGroup.Key} days present");
                foreach (var sub in dateGroup)
                {
                    Console.WriteLine($"  {sub.Name}");
                }
                Console.WriteLine("----------------------");
            }


            // attendance more than 20.
            var above20 = attendance.Where((c) => c.DaysPresent >= 20).Select(c => c.Name).ToList();
            Console.WriteLine($"Candidates attending more than 20 days: { string.Join(", ", above20) }\n\n");


            var byGrade = attendance.GroupBy((a) => a.Grade);

            foreach (var gradeGroup in byGrade)
            {
                Console.WriteLine($"Grade {gradeGroup.Key}: ");
                foreach (var sub in gradeGroup)
                {
                    Console.WriteLine($"  {sub.Name} - {sub.DaysPresent} days present");
                }
                Console.WriteLine("----------------------");
            }

            Console.WriteLine("\n\n-------------------------------\n\n");


            var logs = new[]
            {
                new { Id = 1, Type = "Error", Message = "File not found" },
                new { Id = 2, Type = "Warning", Message = "Low memory" },
                new { Id = 3, Type = "Error", Message = "Access denied" },
                new { Id = 4, Type = "Info", Message = "Operation completed" },
                new { Id = 5, Type = "Warning", Message = "CPU usage high" }
            };

            var byType = logs.GroupBy((l) => l.Type);

            foreach (var logType in byType)
            {
                Console.WriteLine($"{logType.Key} Logs:");
                foreach (var log in logType)
                {
                    Console.WriteLine($" #{log.Id} {log.Message}");
                }
            }

            Console.WriteLine("\n\n-------------------------------\n\n");


            var nlogs = new[]
            {
                new { Date = "2025-10-28", Type = "Error", Message = "Disk full" },
                new { Date = "2025-10-28", Type = "Info", Message = "Started backup" },
                new { Date = "2025-10-29", Type = "Warning", Message = "Network issue" },
                new { Date = "2025-10-29", Type = "Error", Message = "Backup failed" }
            };

            var byDate = nlogs.GroupBy((l) => l.Date);

            foreach (var logDate in byDate)
            {
                Console.WriteLine($"Logs on {logDate.Key}:");
                foreach (var log in logDate)
                {
                    Console.WriteLine($" [{log.Type}] {log.Message}");
                }
            }

            Console.WriteLine("\n\n-------------------------------\n\n");

        }
    }
}
