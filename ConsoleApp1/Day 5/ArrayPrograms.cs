using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ArrayPrograms
    {
        public static void CountEvenOddNumbers(int[] array)
        {

            int even = 0;
            int odd = 0;

            foreach (int i in array)
            {
                if (i % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }

            Console.WriteLine($"Number of even numbers in array: {even}");
            Console.WriteLine($"Number of odd numbers in array: {odd}");
        }

        public static void CopyElementsToAnotherArray(int[] array1, int[] array2)
        {
            Array.Resize(ref array2, array1.Length);
            Array.Copy(array1, array2, array1.Length);
            Console.WriteLine("Elements copied to another array successfully.");
        }

        public static void ReverseArrayAndPrint(int[] array)
        {
            Console.WriteLine("Original array: [" + string.Join(", ", array) + "]");
            int i = 0;
            int j = array.Length - 1;

            while (i < j)
            {
                int startElem = array[i];
                int endElem = array[j];
                array[i] = endElem;
                array[j] = startElem;
                i++;
                j--;
            }

            Console.WriteLine("Reversed array: [" + string.Join(", ", array) + "]");
        }

        public static void FindSecondLargestNumber(int[] array)
        {
            int finalSecondLargest = -99;
            int largest = -99;

            foreach (int num in array)
            {
                if (num > largest)
                {
                    finalSecondLargest = largest;
                    largest = num;
                }
                else if (num > finalSecondLargest && num < largest)
                {
                    finalSecondLargest = num;
                }
            }

            Console.WriteLine($"The second largest number in the array is: {finalSecondLargest}");
        }

        public static void SortArrayInAscDesc(int[] array)
        {
            Console.Write("[");
            Console.WriteLine($"Original array: [{string.Join(", ", array)}]");
            Console.Write("]");

            Array.Sort(array);
            Console.Write("[");
            Console.WriteLine($"Ascending Order: [{string.Join(", ", array)}]");
            Console.Write("]");

            Array.Reverse(array);
            Console.Write("[");
            Console.WriteLine($"Descending Order: [{string.Join(", ", array)}]");
            Console.Write("]");

        }

        public static void CountFrequency(int[] array)
        {
            Dictionary<int, int> counter = new Dictionary<int, int>();

            foreach (int num in array)
            {
                counter[num] += 1;
            }

            Console.WriteLine($"Frequency of elements in the array: ");
            foreach (int num in counter.Keys.ToList())
            {
                Console.Write($"{num} - {counter[num]} times, ");
            }

            Console.WriteLine();
        }

        public static void MergeTwoArrays(int[] array1, int[] array2, int[] array3)
        {
            Array.Resize(ref array3, array1.Length + array2.Length);
            int index = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                array3[index] = array1[i];
                index++;
            }
            for (int j = 0;  j < array2.Length; j++)
            {
                array3[index] = array2[j];
                index++;
            }

            Console.WriteLine($"Merged Array: [{string.Join(",", array3)}]");
        }

        public static void RemoveDuplicates(int[] array)
        {
            int[] temp = new int[array.Length];
            int[] seen = new int[array.Length];
            Array.Sort(array);

            for (int i = 0; i <  array.Length; i++)
            {
                bool isDuplicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    temp.Append(i);
                }
            }

            Console.WriteLine($"Original Array: [{string.Join(", ", array)}]");
            Console.WriteLine($"Array after removing duplicates: [{string.Join(", ", temp)}]");
        }
    }
}
