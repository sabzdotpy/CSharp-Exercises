using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2;

namespace ConsoleApp1.Day16
{

    class Employee
    {
        private int salary;  // hidden field
                             // Property to control access
        public int Salary
        {
            get { return salary; }
            set
            {
                if (value > 0)
                    salary = value;
                else
                    Console.WriteLine("Invalid salary!");
            }
        }
    }

    // Task 1 - All modifiers
    class A1
    {
        public void AddPublic(int a, int b)
        {
            Console.WriteLine("Public Add: " + (a + b));
        }

        private void AddPrivate(int a, int b)
        {
            Console.WriteLine("Private Add: " + (a + b));
        }

        protected void AddProtected(int a, int b)
        {
            Console.WriteLine("Protected Add: " + (a + b));
        }

        internal void AddInternal(int a, int b)
        {
            Console.WriteLine("Internal Add: " + (a + b));
        }

        protected internal void AddProtectedInternal(int a, int b)
        {
            Console.WriteLine("Protected Internal Add: " + (a + b));
        }

        private protected void AddPrivateProtected(int a, int b)
        {
            Console.WriteLine("Private Protected Add: " + (a + b));
        }
    }

    public class Day16Task
    {
        public void AccessModifierDemo()
        {
            A1 obj = new A1();

            obj.AddPublic(1, 2);             // accessible
            //obj.AddPrivate(1, 2);         // not accessible — private
            //obj.AddProtected(1, 2);       // not accessible — protected
            obj.AddInternal(1, 2);           // accessible — same assembly
            obj.AddProtectedInternal(1, 2);  // accessible — same assembly
            //obj.AddPrivateProtected(1, 2); // not accessible — private protected

        }

    }


    // Task 2 - internal and protected with derived classes
    class A2
    {
        internal void InternalAdd(int a, int b)
        {
            Console.WriteLine("Internal Add: " + (a + b));
        }

        protected void ProtectedAdd(int a, int b)
        {
            Console.WriteLine("Protected Add: " + (a + b));
        }
    }

    class Program : A2
    {
        public void Run()
        {
            A2 obj = new A2();
            obj.InternalAdd(1, 2);  // accessible — same assembly
            // obj.ProtectedAdd(1, 2); // not accessible via object
            ProtectedAdd(3, 4); // accessible via inheritance
        }
    }

    // Task 3 - Another file
    class AnotherFileProgram
    {
        public void Run()
        {
            A1AnotherFile obj = new A1AnotherFile();
            obj.Add(5, 5); // works — internal is accessible in same assembly
        }
    }

    // Task 4 - Another Project
    //class AnotherProjectProgram
    //{
    //    static void Main()
    //    {
    //        K1 obj = new K1();
    //        obj.Add(2, 3);             // works - public
    //        //obj.AddInternal(2, 3);  // not accessible — internal in another assembly
    //    }
    //}


    // Task 5 - Fields
    public class FieldsDemo
    {
        public string name;           // accessible everywhere
        private string dept;          // only inside A1
        protected string city;        // accessible in derived classes
        internal string country;      // accessible in same assembly
        protected internal string code; // accessible in same assembly or derived
        private protected string id;  // accessible only in derived classes in same assembly
    }

    //class ModifyFieldsDemo
    //{
    //    static void Main()
    //    {
    //        FieldsDemo obj = new FieldsDemo();
    //        obj.name = "S";       // works - public
    //         //obj.dept = "IT";   // private - doesnt work
    //         //obj.city = "Madurai"; // protected - doesnt work
    //        obj.country = "India";  // internal
    //        obj.code = "91";      // protected internal
    //        // obj.id = "P001";     // private protected - doesnt wprk.
    //    }
    //}

}