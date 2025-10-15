using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SortinAndSearchingAlgorithms
    {
        public static void BubbleSort()
        {
            Console.WriteLine("Bubble Sort");
            Console.Write("Enter size of array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter element #{i + 1}: ");
                int x = Convert.ToInt32(Console.ReadLine());
                array[i] = x;
            }

            Console.WriteLine($"Array before sorting: [{string.Join(", ", array)}]");

            for (int i = 0; i < n; i++)
            {
                for (int j =  0; j < n; j++)
                {
                    if (array[j] > array[i])
                    {
                        (array[i], array[j]) = (array[j], array[i]);
                    }
                }
            }

            Console.WriteLine($"Array after sorting with bubble sort: [{string.Join(", ", array)}]");

        }

        public static void SelectionSort()
        {
            Console.WriteLine("Selection Sort");
            Console.Write("Enter size of array: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter element #{i + 1}: ");
                int x = Convert.ToInt32(Console.ReadLine());
                array[i] = x;
            }

            for (int i = 0; i < n;  i++)
            {
                int minimum_index = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[minimum_index] )
                    {
                        minimum_index = j;
                    }
                }

                // now we have the ACTUAL index where elem is minimum. so swap.
                //int temp = array[i];
                //array[i] = array[minimum_index];
                //array[minimum_index] = temp;
                (array[i], array[minimum_index]) = (array[minimum_index], array[i]);

            }

            Console.WriteLine($"Array after sorting with selection sort: [{string.Join(", ", array)}]");
        }

        public static void InsertionSort()
        {
            Console.WriteLine("Insertion Sort");
            Console.Write("Enter size of array: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter element #{i + 1}: ");
                int x = Convert.ToInt32(Console.ReadLine());
                array[i] = x;
            }

            for (int i = 2; i < n; i++)
            {
                int key = array[i];
                int j = i - 1;
                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }
            
            Console.WriteLine($"Array after sorting with insertion sort: [{string.Join(", ", array)}]");
        }

        public static void LinearSearch()
        {
            Console.WriteLine("Linear Search");
            Console.Write("Enter the size of the array: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter element #{i + 1}: ");
                int x = Convert.ToInt32(Console.ReadLine());
                array[i] = x;
            }

            Console.Write("Enter target element: ");
            int target = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                if (array[i] == target)
                {
                    Console.WriteLine($"Element found at index {i}");
                    return;
                }
            }
        }

        public static void BinarySearch()
        {
            Console.WriteLine("Binary Search");
            Console.Write("Enter the size of the array: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter element #{i + 1}: ");
                int x = Convert.ToInt32(Console.ReadLine());
                array[i] = x;
            }

            Console.Write("Enter target element: ");
            int target = Convert.ToInt32(Console.ReadLine());

            int left = 0;
            int right = n;

            while (left < right)
            {
                int mid = (right + left) / 2;

                if (target == array[mid])
                {
                    Console.WriteLine($"Element found at index {mid}");
                    return;
                }
                else if (target > array[mid])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            Console.WriteLine("Element not found");
        }

        public static void SortOnlyEvenNumbers()
        {
            
        }

        public static void DutchNationalFlagAlgorithm()
        {

        }

        public static void FindKthSmallestAndLargest()
        {

        }

        public static void CheckIfTwoArraysAreEqualAfterSorting()
        {

        } 

        public static void FindCommonElementsBetweenTwoArrays()
        {
            Dictionary<int, int> counter = [];

            Console.WriteLine("Finding Common Elements in Two Arrays:");
            Console.Write("Enter the size of array 1: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            int[] array1 = new int[n1];
            for (int i = 0; i < n1; i++)
            {
                Console.Write($"Enter element #{i + 1}: ");
                int x = Convert.ToInt32(Console.ReadLine());
                array1[i] = x;
            }

            Console.Write("Enter the size of array 2: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            int[] array2 = new int[n1];
            for (int i = 0; i < n1; i++)
            {
                Console.Write($"Enter element #{i + 1}: ");
                int x = Convert.ToInt32(Console.ReadLine());
                array1[i] = x;
            }

            foreach (int i in array1)
            {
                if (counter.TryGetValue(i, out int value))
                {
                    counter[i] = ++value;
                }
                else
                {
                    counter[i] = 1;
                }
            }

            foreach (int i in array2)
            {
                if (counter.TryGetValue(i, out int value))
                {
                    counter[i] = ++value;
                }
                else
                {
                    counter[i] = 1;
                }
            }

            List<int> result = new List<int>();
            foreach (var item in counter)
            {
                if (item.Value > 1)
                {
                    result.Add(item.Key);
                }
            }

            Console.WriteLine($"Common elements in two lists are: [{string.Join(", ", result)}]");

        }

        public static void TwoSum()
        {

        }
    }
}
