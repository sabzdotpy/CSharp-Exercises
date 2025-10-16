using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class _3dArray
    {
        public static void GetAndMake3DArray()
        {
            Console.WriteLine("3D Array Creation: ");
            Console.Write("Enter Layer Count: ");
            int layers = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Row Count: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Column Count: ");
            int cols = Convert.ToInt32(Console.ReadLine());
            int[,,] array = new int[layers, rows, cols];

            for (int i = 0; i < layers; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    for (int k = 0; k < cols; k++)
                    {
                        Console.Write($"Enter element [{i},{j},{k}]: ");
                        array[i, j, k] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }

            // printing 3d arr
            Console.Write("[ ");
            for (int i = 0; i < layers; i++)
            {
                Console.Write("[ ");
                for (int j = 0; j < rows; j++)
                {
                    Console.Write("[ ");
                    for (int k = 0; k < cols; k++)
                    {
                        Console.Write($"{array[i,j,k]}, ");
                    }
                    Console.Write("], ");
                }
                Console.Write("], ");
            }
            Console.Write("]");

        }
    }
}
