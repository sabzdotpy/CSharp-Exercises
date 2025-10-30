using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Day_12___Inheritance
{


    class Person
    {
        public string name {  get; set; }
        public int age { get; set; }
        public string qualification { get; set; }

        public Person()
        {
            Console.WriteLine("Creating new person: ");
            Console.Write("Enter name: ");
            name = Console.ReadLine();

            Console.Write("Enter age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter qualification: ");
            qualification = Console.ReadLine();

        }

    }

    class Teacher : Person
    {
        public List<string> subjects = [];

        public Teacher()
        {
            Console.WriteLine("Getting details for teacher: ");
            Console.Write($"Enter number of subjects for {name}: ");
            int numOfSubs = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < numOfSubs; i++)
            {
                string sub = Console.ReadLine();
                subjects.Add(sub!);
            }
            Console.WriteLine($"Teacher {name} created with {numOfSubs} subjects.");

        }
    }

    class HeadTeacher : Teacher
    {
        public string department;

        public HeadTeacher()
        {
            Console.WriteLine("Getting details for Head Teacher: ");
            Console.Write($"Enter department of {name}: ");
            department = Console.ReadLine();
        }
    }

    internal class TeacherProgram
    {
        public static void createAll()
        {
            Console.Write("Are you a teacher (t) or headteacher (h)? ");
            char choice = Convert.ToChar(Console.ReadLine());
            switch (choice)
            {
                case 't':
                    Teacher teacher = new();
                    break;
                case 'h':
                    HeadTeacher head = new();
                    break;
            }
        }
    }
}
