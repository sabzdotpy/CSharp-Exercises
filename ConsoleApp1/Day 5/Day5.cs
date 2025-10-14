using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Day5
    {
        public static void start()
        {
            Console.WriteLine("1/6 Count Even and Odd Numbers");
            Console.Write("Enter size of array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter element #{i + 1}: ");
                int elem = Convert.ToInt32(Console.ReadLine());
                array[i] = elem;
            }
            ArrayPrograms.CountEvenOddNumbers(array);

            // ------------
            Console.WriteLine("\n\n-----------------------\n\n");
            
            Console.WriteLine("2/6 Copy Elements to Another Array");
            Console.Write("Enter size of array: ");
            size = Convert.ToInt32(Console.ReadLine());
            array = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter element #{i + 1}: ");
                int elem = Convert.ToInt32(Console.ReadLine());
                array[i] = elem;
            }
            int[] brandNewArray = new int[array.Length];
            ArrayPrograms.CopyElementsToAnotherArray(array, brandNewArray);
            Console.WriteLine($"New Array after copying: {string.Join(", ", brandNewArray)}");

            // ------------
            Console.WriteLine("\n\n-----------------------\n\n");

            Console.WriteLine("3/6 Reverse Array");
            Console.Write("Enter size of array: ");
            size = Convert.ToInt32(Console.ReadLine());
            array = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter element #{i + 1}: ");
                int elem = Convert.ToInt32(Console.ReadLine());
                array[i] = elem;
            }

            ArrayPrograms.ReverseArrayAndPrint(array);


            // ------------
            Console.WriteLine("\n\n-----------------------\n\n");

            Console.WriteLine("4/6 Second Largest Number");
            Console.Write("Enter size of array: ");
            size = Convert.ToInt32(Console.ReadLine());
            array = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter element #{i + 1}: ");
                int elem = Convert.ToInt32(Console.ReadLine());
                array[i] = elem;
            }

            ArrayPrograms.FindSecondLargestNumber(array);

            // ------------
            Console.WriteLine("\n\n-----------------------\n\n");

            Console.WriteLine("5/6 Sort Array In Ascending and Descending Order:");
            Console.Write("Enter size of array: ");
            size = Convert.ToInt32(Console.ReadLine());
            array = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter element #{i + 1}: ");
                int elem = Convert.ToInt32(Console.ReadLine());
                array[i] = elem;
            }

            ArrayPrograms.SortArrayInAscDesc(array);

            // ------------
            Console.WriteLine("\n\n-----------------------\n\n");

            Console.WriteLine("6/6 Merge Two Arrays");
            Console.Write("Enter size of array 1: ");
            int size1 = Convert.ToInt32(Console.ReadLine());
            int[] array1 = new int[size1];
            for (int i = 0; i < size1; i++)
            {
                Console.Write($"Enter element #{i + 1}: ");
                int elem = Convert.ToInt32(Console.ReadLine());
                array1[i] = elem;
            }

            Console.WriteLine("----");
            Console.Write("Enter size of array 2: ");
            int size2 = Convert.ToInt32(Console.ReadLine());
            int[] array2 = new int[size2];
            for (int i = 0; i < size2; i++)
            {
                Console.Write($"Enter element #{i + 1}: ");
                int elem = Convert.ToInt32(Console.ReadLine());
                array2[i] = elem;
            }

            int[] array3 = new int[size1 + size2];

            ArrayPrograms.MergeTwoArrays(array1, array2, array3);

        }
    }
}
