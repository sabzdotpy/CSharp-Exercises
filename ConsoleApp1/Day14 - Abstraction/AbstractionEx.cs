using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Day_14___Abstraction
{
        public abstract class Vehicle
        {
            public abstract void PrintType();
        }

        public class Tesla : Vehicle
        {
            public override void PrintType()
            {
                Console.WriteLine("This is a Tesla");
            }
        }

        public class Honda : Vehicle
        {
            public override void PrintType()
            {
                Console.WriteLine("This is a honda.");
            }
        }


        public interface IShape
        {
            void Draw();
            void PrintName();
        }

        public class Circle : IShape
        {
            public void Draw()
            {
                Console.WriteLine("Drawing circle");
            }

            public void PrintName()
            {
                Console.WriteLine("Name of Shape: Circle");
            }
        }


        public class Square : IShape { 
            
            public void Draw()
            {
                Console.WriteLine("Drawing square");
            }

            public void PrintName()
            {
                Console.WriteLine("Name of Shape: Square");
            }
        
        }


        public class ShapeFactory
        {
            public static IShape GetShape(string shapeType)
            {
                if (shapeType == "circle")
                    return new Circle();
                else if (shapeType == "square")
                    return new Square();
                else
                    return null;
            }
        }

}
