using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Day_15
{
    internal class Day15
    {
        public static void start()
        {
            //FileOps fileOps = new FileOps("D:/Code/C#/test1.txt");
            //fileOps.ReadAFile();
            //fileOps.WriteAFile("hello world");
            //fileOps.ReadAFile();
            //fileOps.StreamWrite("stream text writing 2");
            //fileOps.StreamRead();


            Console.WriteLine("--------------------------------");
            Console.WriteLine("Welcome to Student Database System");
            Console.WriteLine("--------------------------------");

            string path = "D:/Code/C#/ConsoleApp1/ConsoleApp1/Day15 - Files/database.txt";

            StudentDatabase sd = new StudentDatabase(path);

            while (true)
            {
                Console.WriteLine("\nSelect an operation:");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. View All Students");
                Console.WriteLine("3. Find Student by Name");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice (1-4): ");

                string? choice = Console.ReadLine();
                Console.WriteLine("--------------------------------");

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter student name: ");
                        string name = Console.ReadLine() ?? string.Empty;

                        Console.Write("Enter student age: ");
                        int age;
                        while (!int.TryParse(Console.ReadLine(), out age))
                        {
                            Console.Write("Invalid input. Enter numeric age: ");
                        }

                        Console.Write("Enter student department: ");
                        string department = Console.ReadLine() ?? string.Empty;

                        sd.Add(name, age, department);
                        break;

                    case "2":
                        sd.Read();
                        break;

                    case "3":
                        Console.Write("Enter name to search: ");
                        string findName = Console.ReadLine() ?? string.Empty;
                        sd.Find(findName);
                        break;

                    case "4":
                        Console.WriteLine("Exiting Student Database System...");
                        Console.WriteLine("--------------------------------");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                        break;
                }
            }


            }
    }
}
