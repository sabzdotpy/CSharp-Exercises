using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Day17
{

    class InvalidAgeException : Exception
    {
        public InvalidAgeException(int age) : base($"Invalid age: {age} years.")  {
        }
    }

    internal class ExceptionHandling
    {
        public static void demo()
        {
            int c = 12;
            Console.WriteLine($"C = {c}");
            
            try
            {
                if (c < 18)
                {
                    throw new InvalidAgeException(c);
                }

            }
            catch (InvalidAgeException e)
            {
                Console.WriteLine("caught invalid age exception...");
                Console.WriteLine(e.ToString());
            }

            
        }
    }
}
