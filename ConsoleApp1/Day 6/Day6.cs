using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Day6
    {

        public static void start()
        {

            Console.WriteLine("11. Alphabets Pattern");
            Console.Write("Enter A, B or C: ");
            char letter = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();
            switch (letter)
            {
                case 'A':
                    StarPatterns.APattern(5);
                    break;
                case 'B':
                    StarPatterns.BPattern(5);
                    break;
                case 'C':
                    StarPatterns.CPattern(5);
                    break;
                default:
                    break;
            }

            Console.WriteLine();

            Console.WriteLine("11. Alphabets Pattern");
            Console.Write("Enter A, B or C: ");
            letter = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();
            switch (letter)
            {
                case 'A':
                    StarPatterns.APattern(5);
                    break;
                case 'B':
                    StarPatterns.BPattern(5);
                    break;
                case 'C':
                    StarPatterns.CPattern(5);
                    break;
                default:
                    break;
            }

            Console.WriteLine();

            Console.WriteLine("11. Alphabets Pattern");
            Console.Write("Enter A, B or C: ");
            letter = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();
            switch (letter)
            {
                case 'A':
                    StarPatterns.APattern(5);
                    break;
                case 'B':
                    StarPatterns.BPattern(5);
                    break;
                case 'C':
                    StarPatterns.CPattern(5);
                    break;
                default:
                    break;
            }

            Console.WriteLine();

            Console.WriteLine("1. Star Square Pattern");
            Console.Write("Enter size: ");
            int size = Convert.ToInt32(Console.ReadLine());
            StarPatterns.StarSquare(size);

            Console.WriteLine("----------------");

            Console.WriteLine("2. Right Triangle");
            Console.Write("Enter height: ");
            int height = Convert.ToInt32(Console.ReadLine());
            StarPatterns.RightTriangle(height);

            Console.WriteLine("----------------");

            Console.WriteLine("3. Inverse Right Triangle");
            Console.Write("Enter height: ");
            height = Convert.ToInt32(Console.ReadLine());
            StarPatterns.InverseRightTriangle(height);

            Console.WriteLine("----------------");

            Console.WriteLine("4. Left Triangle");
            Console.Write("Enter height: ");
            height = Convert.ToInt32(Console.ReadLine());
            StarPatterns.LeftTriangle(height);

            Console.WriteLine("----------------");

            Console.WriteLine("5. Even Numbers Square:");
            Console.Write("Enter height: ");
            height = Convert.ToInt32(Console.ReadLine());
            StarPatterns.EvenNumberSquarePattern(height);

            Console.WriteLine("----------------");

            Console.WriteLine("6. Binary Square");
            Console.Write("Enter height: ");
            height = Convert.ToInt32(Console.ReadLine());
            StarPatterns.BinarySquare(height);

            Console.WriteLine("----------------");

            Console.WriteLine("7. Hollow Square");
            Console.Write("Enter side: ");
            int side = Convert.ToInt32(Console.ReadLine());
            StarPatterns.HollowSquare(side);

            Console.WriteLine("----------------");

            Console.WriteLine("8. Hollow Right Triangle:");
            Console.Write("Enter height: ");
            height = Convert.ToInt32(Console.ReadLine());
            StarPatterns.HollowRightTriangle(height);

            Console.WriteLine("----------------");

            Console.WriteLine("9. N Pattern");
            Console.Write("Enter height: ");
            height = Convert.ToInt32(Console.ReadLine());
            StarPatterns.NPattern(height);

            Console.WriteLine("----------------");

            Console.WriteLine("10. Four Pattern");
            Console.Write("Enter width: ");
            int width = Convert.ToInt32(Console.ReadLine());
            StarPatterns.FourPattern(width);

        }

    }
}
