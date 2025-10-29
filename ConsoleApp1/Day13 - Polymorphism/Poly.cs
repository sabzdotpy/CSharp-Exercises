using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Day13___Polymorphism
{

    class MathF
    {
        public virtual int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public float Add(float a, float b)
        {
            return a + b;
        }

        public float Add(float a, float b, float c)
        {
            return a + b + c;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Add(double a, double b, double c)
        {
            return a + b + c;
        }
    }

    class MathG: MathF
    {
        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Add(int a, int b)
        {
            Console.WriteLine($"Base class Add: {a - b}");
            Console.WriteLine($"Base class Add: {base.Add(a, b)}");

            //return a - b;
            return base.Add(a, b);
        }
    }

    public class Poly
    {
        public Poly()
        {
            MathF mf = new();
            MathG mg = new();
            double x = mf.Add(1.0, 2.0, 3.0);
            int z = mf.Add(1, 4);
            Console.WriteLine($"Class MathF.Add -> 1 + 4 = {z}");
            z = mg.Add(1, 4);
            Console.WriteLine($"Class MathG.Add -> 1 + 4 = {z}");
        }
    }
}
