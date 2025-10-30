using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConsoleApp1.Day_15
{
    internal class StudentDatabase
    {
        string path = string.Empty;

        public StudentDatabase(string path) 
        {
            this.path = path;
            Console.WriteLine("\n--------------------------------");
            Console.WriteLine($"Student database initialized in path: {path}");
            Console.WriteLine("--------------------------------");
        }

        public void Add(string name, int age, string department)
        {
            string content = $"{name}, {age}, {department}\n";
            if (File.Exists(this.path))
            {
                Console.WriteLine($"Appending student {name}, as database already exists.");
                File.AppendAllText(this.path, content);
            }
            else
            {
                Console.WriteLine("Creating new database file as database doesn't exist.");
                File.Create(this.path);
                File.WriteAllText(this.path, content);
            }

            Console.WriteLine("Student Add Operation complete.");
            Console.WriteLine("--------------------------------");
        }

        public void Read()
        {
            if (!File.Exists(this.path))
            {
                File.Create(this.path);
                Console.WriteLine("Student database not found. Created a blank one now.\n--------------------------------");
                return;
            }

            Console.WriteLine("Printing entire student database: ");
            Console.WriteLine(File.ReadAllText(this.path));
            Console.WriteLine("--------------------------------");
        }

        public void Find(string name)
        {
            using (StreamReader  sr = new StreamReader(this.path))
            {
                string line;
                while ((line = sr.ReadLine()) != null) {
                    string[] data = line.Split(',');
                    if (data[0] == name)
                    {
                        Console.WriteLine($"Found student with name {name}");
                        Console.WriteLine($"Data: {line}");
                        Console.WriteLine("--------------------------------");
                        return;
                    }
                }

                Console.WriteLine($"Student {name} not found in database.");
                Console.WriteLine("--------------------------------");
            }
        }

    }
}
