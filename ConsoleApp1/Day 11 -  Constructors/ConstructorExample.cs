using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Day_11____Constructors
{
    internal class ConstructorExample
    {
        int a;
        int b;
        // default constructor
        public ConstructorExample()
        {
            Console.WriteLine("Welcome to default constructor");
        }

        // parameterized constructor
        public ConstructorExample(string name)
        {
            Console.WriteLine($"Welcome {name}");
        }

        static ConstructorExample()
        {
            Console.WriteLine("Static constructor called");
        }

        private ConstructorExample(int x)
        {
            Console.WriteLine("Private constructor called.");
        }

        public ConstructorExample(ConstructorExample other)
        {
            Console.WriteLine("Copy constructor called");
        }

        public void AssignValues(int aValue, int bValue)
        {
            this.a = aValue;
            this.b = bValue;
            Console.WriteLine($"Value {aValue} assigned to A, {bValue} assigned to B");
        }

        public void Addition()
        {
            Console.WriteLine($"{a} + {b} = {a+b}");
        }

        public void Multiplication()
        {
            Console.WriteLine($"{a} x {b} = {a * b}");
        }

    }
}
