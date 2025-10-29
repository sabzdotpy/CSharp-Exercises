using ConsoleApp1.Day_12___Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Day_12
{

    class Base
    {
        internal int ID { get; set; }

        internal int Add(int a, int b)
        {
            return a + b;
        }
    }

    class Derived : Base
    {
        internal int Subtract(int a, int b)
        {
            return a - b;
        }
    }

    class SuperDerived : Derived
    {
        internal int Multiply(int a, int b)
        {
            return a * b;
        }
    }

    class Sibling : SuperDerived
    {
        internal int Divide(int a, int b)
        {
            return a / b;
        }
    }

    internal class Day12
    {
        public static void start()
        {
            //Base bs = new();
            //Derived child = new();
            //SuperDerived superDerived = new();
            //Sibling sibling = new();

            //int a = 5;
            //int b = 10;

            //int addOP = child.Add(a, b);
            //Console.WriteLine($"Result: {a} + {b} = {addOP}");

            //int subOP = child.Subtract(a, b);
            //Console.WriteLine($"Result: {a} - {b} = {subOP}");

            //int mulOP = superDerived.Multiply(addOP, subOP);
            //Console.WriteLine($"Result: {addOP} x {subOP} = {mulOP}");

            //int divOP = sibling.Divide(addOP, subOP);
            //Console.WriteLine($"Result: {addOP} / {subOP} = {divOP}");

            //TeacherProgram.createAll();

            Console.WriteLine("Starting loan program.");
            Human h = new();
            h.Loan();
            h.Rent();
            h.PersonalSpent();
        }
    }
}

