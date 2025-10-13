using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ArrayBasics
    {
        public ArrayBasics()
        {
            Console.WriteLine("Array Program: ");

            Console.Write("Enter the size of the array: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[size];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                int elem = Convert.ToInt32(Console.ReadLine());
                array[i] = elem;
            }

            Console.Write("The Final Array is: [");
            Console.Write(string.Join(",", array));
            Console.WriteLine("]");

            Console.WriteLine();

            Console.WriteLine($"Minimum Element: {array.Min()}");
            Console.WriteLine($"Maximum Element: {array.Max()}");
            int sumOfEvenNumbers = 0;

            foreach (int i in array)
            {
                if (i % 2 == 0)
                {
                    sumOfEvenNumbers += i;
                }
            }

            Console.WriteLine($"Sum of Even Numbers in array = {sumOfEvenNumbers}");

        }
    }
}
