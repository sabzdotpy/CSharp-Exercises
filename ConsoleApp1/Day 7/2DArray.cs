using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class _2DArray
    {
        public static void TwoDArray()
        {
            Console.WriteLine("2D Array: ");
            Console.Write("Enter number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of columns: ");
            int cols = Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Enter element at position [{i}][{j}]: ");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("[ ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write("[ ");
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]}, ");
                }
                Console.WriteLine("], ");
            }
            Console.Write("] ");
        }

        public static void EvenNumbersIn2DArray()
        {
            Console.WriteLine("Even Numbers In 2D Array");

            Console.Write("Enter number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of columns: ");
            int cols = Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Enter element at position [{i}][{j}]: ");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Finding even elements in 2d array...");

            int sumOfEven = 0;
            int sumOfOdd = 0; 
            List<int> evenNumbers = new List<int>();

            Console.WriteLine("[ ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write("[ ");
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    int elem = arr[i, j];
                    if (elem % 2 == 0)
                    {
                        evenNumbers.Add(elem);
                        sumOfEven += elem;
                    }
                    else
                    {
                        sumOfOdd += elem;
                    }
                    Console.Write($"{arr[i, j]}, ");
                }
                Console.WriteLine("], ");
            }
            Console.WriteLine("] ");

            Console.WriteLine($"Even Numbers in the array: {string.Join(", ", evenNumbers)}");
            Console.WriteLine($"Sum of Even Numbers in Array: {sumOfEven}");
            Console.WriteLine($"Sum of Odd Numbers in Array: {sumOfOdd}");

        }

        private static bool isPrime(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) return false;
            }

            return true;
        }

        public static void FindPrimeNumbersInArray()
        {
            Console.WriteLine("Prime Numbers In 2D Array");

            Console.Write("Enter number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of columns: ");
            int cols = Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Enter element at position [{i}][{j}]: ");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Finding Prime numbers in the array: ");
            List<int> primes = [];

            for (int i = 0; i < rows; i++)
            {
                for (int j =  0; j < cols; j++)
                {
                    int elem = arr[i, j];
                    if (isPrime(elem))
                    {
                        primes.Add(elem);
                    }

                }
            }

            Console.WriteLine($"Prime Numbers in the array: {string.Join(", ", primes)}");

        }
    }
}
