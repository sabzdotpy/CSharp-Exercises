using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class StarPatterns
    {
        internal static void StarSquare(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                for (int j =  1; j <= size; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        internal static void RightTriangle(int height)
        {
            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }

        internal static void InverseRightTriangle(int height)
        {
            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= height - i + 1; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }

        internal static void LeftTriangle(int height)
        {
            for (int i = 1; i <= height; i++)
            {
                for (int s = 1; s <= height - i; s++)
                {
                    Console.Write("  ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }

                Console.WriteLine();
            }
        }

        internal static void EvenNumberSquarePattern(int height)
        {
            int count = 2;

            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= height; j++)
                {
                    Console.Write($"{count++} ");
                }
                Console.WriteLine();
            }
        }

        internal static void BinarySquare(int height)
        {
            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= height; j++)
                {
                    if (j % 2 != 0) Console.Write("0 ");
                    else Console.Write("1 ");
                }
                Console.WriteLine();
            }
        }

        internal static void HollowSquare(int side)
        {
            for (int i = 1; i <= side; i++)
            {
                for (int j = 1; j <= side; j++)
                {
                    if (i == 1 || i == side || j == 1 || j == side) Console.Write($"{j} ");
                    else Console.Write("  ");
                }
                Console.WriteLine();
            }
        }

        internal static void HollowRightTriangle(int height)
        {
            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i == 1 || i == height || j == i || j == 1) Console.Write($"{j} ");
                    else Console.Write("  ");
                }
                Console.WriteLine();
            }
        }

        internal static void NPattern(int height)
        {
            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= height; j++)
                {
                    if (j == 1 || j == height || i == j) Console.Write("* ");
                    else Console.Write("  ");
                }
                Console.WriteLine();
            }
        }

        internal static void FourPattern(int width = 4)
        {
            int legHeight = width / 2 - 1;
            for (int i = 1; i <= width; i++)
            {
                for (int j = 1; j <= width; j++)
                {
                    if (j == (width - i) || j == (width) || i == (width)) Console.Write("* ");
                    else Console.Write("  ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i <= legHeight; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (j == width - 1) Console.Write("*");
                    else Console.Write("  ");
                }
                Console.WriteLine();
            }
        }

        internal static void APattern(int height)
        {
            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= height; j++)
                {
                    if (j == 1 || j == height || i == 1 || i == Convert.ToInt32(height / 2) + 1) Console.Write("* ");
                    else Console.Write("  ");
                }
                Console.WriteLine();
            }
        }

        internal static void BPattern(int height)
        {
            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= height; j++)
                {
                    if (j == 1 || j == height || i == 1 || (i == Convert.ToInt32(height / 2) + 1) || i == height && ((i != 1 || i != height) && (j != height)) ) Console.Write("* ");
                    else Console.Write("  ");
                }
                Console.WriteLine();
            }
        }

        internal static void CPattern(int height)
        {
            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= height; j++)
                {
                    if (j == 1 || i == 1 || i == height) Console.Write("* ");
                    else Console.Write("  ");
                }
                Console.WriteLine();
            }
        }
    }
}
