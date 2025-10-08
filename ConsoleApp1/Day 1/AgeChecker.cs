using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class AgeChecker
    {
        public static void Compare(int age)
        {
            if (age < 18)
            {
                Console.WriteLine("Given age is less than 18, not allowed to vote.");
            }
            else
            {
                Console.WriteLine("Given age is 18 or more, allowed to vote.");
            }
        }
    }
}
