using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class _2DArrayPrograms
    {
        public static void PrintArrayAsMatrix(int[,] arr)
        {
            Console.WriteLine("Printing as Matrix");
            Console.WriteLine("[");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write("  [ ");
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($" {arr[i, j]}, ");
                }
                Console.WriteLine("],");
            }
            Console.WriteLine("]");
        }

        public static void SumOfEachRowMatrix(int[,] arr)
        {
            PrintArrayAsMatrix(arr);
            Console.WriteLine();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int rowSum = 0;

                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    int elem = arr[i, j];
                    rowSum += elem;
                }

                Console.WriteLine($"Sum of row {i} = {rowSum}");
            }
        }

        public static void SumOfEachColumnMatrix(int[,] arr)
        {
            PrintArrayAsMatrix(arr);
            Console.WriteLine();

            for (int i = 0; i < arr.GetLength(1); i++)
            {
                int colSum = 0;

                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    colSum += arr[j, i];
                }
                Console.WriteLine($"Sum of column {i} = {colSum}");
            }
        }

        public static void FindPosition(int[,] arr, int target)
        {
            PrintArrayAsMatrix(arr);
            Console.WriteLine();
            List<int[]> positions = [];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    int elem = arr[i, j];
                    if (elem == target)
                    {
                        positions.Add([i, j]);
                    }
                }
            }

            if (positions.Count > 0)
            {
                Console.WriteLine($"Target can be found at {JsonSerializer.Serialize(positions)}");
            }
            else
            {
                Console.WriteLine("Target is not found in this matrix.");
            }
        }

        public static void Add(int[,] a1, int[,] a2)
        {
            if ( (a1.GetLength(0) != a2.GetLength(0)) || a1.GetLength(1) != a2.GetLength(1) )
            {
                Console.WriteLine("The arrays are not of same dimension. Cannot Add.");
                return;
            }
             
            int[,] newArr = new int[a1.GetLength(0), a2.GetLength(1)];

            for (int i = 0; i < a1.GetLength(0); i++)
            {
                for (int j = 0; j < a1.GetLength(1); j++)
                {
                    int elem1 = a1[i, j];
                    int elem2 = a2[i, j];
                    newArr[i, j] = elem1 + elem2;
                }
            }

            Console.WriteLine("Resultant Matrix after Addition:");
            PrintArrayAsMatrix(newArr);

        }

        public static void Multiply(int[,] a1, int[,] a2)
        {
            if ( a1.GetLength(1) != a2.GetLength(0) )
            {
                Console.WriteLine("Number of columns in first column are not equal to number of rows in second matrix. Cannot Multiply.");
                return;
            }

            int[,] newArr = new int[a1.GetLength(0), a2.GetLength(1)];
            int inner = a1.GetLength(1);

            for (int i = 0; i < a1.GetLength(0); i++)
            {
                for (int j = 0; j < a2.GetLength(1); j++)
                {
                    int sum = 0;
                    for (int k = 0; k < inner; k++)
                    {
                        sum += a1[i, k] * a2[k, j];
                    }
                    newArr[i, j] = sum;
                }
            }

            Console.WriteLine("Resultant Matrix after Multiplication:");
            PrintArrayAsMatrix(newArr);

        }


    }
}
