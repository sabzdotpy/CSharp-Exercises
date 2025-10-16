using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Day7
    {
        public static void start()
        {
            _3dArray.GetAndMake3DArray();
            return;

            Console.WriteLine("1/6 Print 3x3 2D Array as Matrix");
            int[,] arr = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Enter element at [{i},{j}]: ");
                    int elem = Convert.ToInt32(Console.ReadLine());
                    arr[i, j] = elem;
                }
            }

            _2DArrayPrograms.PrintArrayAsMatrix(arr);

            //----
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("2/6 Sum of Each Row in Matrix");
            Console.Write("Enter number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of columns: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            int[,] sumArray = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Enter element at [{i},{j}]: ");
                    int elem = Convert.ToInt32(Console.ReadLine());

                    sumArray[i, j] = elem;
                }
            }

            _2DArrayPrograms.SumOfEachRowMatrix(sumArray);

            //----
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("3/6 Sum of Each Column in Matrix");

            Console.Write("Enter number of rows: ");
            rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of columns: ");
            columns = Convert.ToInt32(Console.ReadLine());

            sumArray = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Enter element at [{i},{j}]: ");
                    int elem = Convert.ToInt32(Console.ReadLine());
                    sumArray[i, j] = elem;
                }
            }

            _2DArrayPrograms.SumOfEachColumnMatrix(sumArray);

            //----
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("4/6 Find Position of Target in 2D Array");

            Console.Write("Enter number of rows: ");
            rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of columns: ");
            columns = Convert.ToInt32(Console.ReadLine());

            arr = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Enter element at [{i},{j}]: ");
                    int elem = Convert.ToInt32(Console.ReadLine());
                    arr[i, j] = elem;
                }
            }

            Console.Write("Enter Target to search: ");
            int target = Convert.ToInt32(Console.ReadLine());

            _2DArrayPrograms.FindPosition(arr, target);

            //----
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("5/6 Addition of Two Matrices");

            Console.Write("Enter number of rows of Matrix 1: ");
            int r1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of columns of Matrix 1: ");
            int c1 = Convert.ToInt32(Console.ReadLine());

            int[,] a1 = new int[r1, c1];
            for (int i = 0; i < r1; i++)
            {
                for (int j = 0; j < c1; j++)
                {
                    Console.Write($"Enter element at [{i},{j}]: ");
                    int elem = Convert.ToInt32(Console.ReadLine());
                    a1[i, j] = elem;
                }
            }

            Console.WriteLine("---------------------------");
            Console.Write("Enter number of rows of Matrix 2: ");
            int r2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of columns of Matrix 2: ");
            int c2 = Convert.ToInt32(Console.ReadLine());

            int[,] a2 = new int[r2, c2];
            for (int i = 0; i < r2; i++)
            {
                for (int j = 0; j < c2; j++)
                {
                    Console.Write($"Enter element at [{i},{j}]: ");
                    int elem = Convert.ToInt32(Console.ReadLine());
                    a2[i, j] = elem;
                }
            }


            _2DArrayPrograms.Add(a1, a2);

            //----
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("6/6 Multiplication of Two Matrices");

            Console.Write("Enter number of rows of Matrix 1: ");
            r1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of columns of Matrix 1: ");
            c1 = Convert.ToInt32(Console.ReadLine());

            a1 = new int[r1, c1];
            for (int i = 0; i < r1; i++)
            {
                for (int j = 0; j < c1; j++)
                {
                    Console.Write($"Enter element at [{i},{j}]: ");
                    int elem = Convert.ToInt32(Console.ReadLine());
                    a1[i, j] = elem;
                }
            }

            Console.WriteLine("---------------------------");
            Console.Write("Enter number of rows of Matrix 2: ");
            r2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of columns of Matrix 2: ");
            c2 = Convert.ToInt32(Console.ReadLine());

            a2 = new int[r2, c2];
            for (int i = 0; i < r2; i++)
            {
                for (int j = 0; j < c2; j++)
                {
                    Console.Write($"Enter element at [{i},{j}]: ");
                    int elem = Convert.ToInt32(Console.ReadLine());
                    a2[i, j] = elem;
                }
            }


            _2DArrayPrograms.Multiply(a1, a2);


        }
    }
}
