using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ArraysExample
    {
        A1 a1 = new A1();
    }
}


public class A1
{
    internal A1()
    {
        int[] age = { 1, 2, 30, 45, 12 };
        Console.WriteLine(age.Length);
        Array.Sort(age);
        foreach (int i in age)
            Console.WriteLine(i);
        Console.WriteLine("____");

        Array.Reverse(age);
        foreach (int i in age)
            Console.WriteLine(i);

        Console.WriteLine("____");

        int[] copy = new int[age.Length];
        // array.copy(from, to, size)
        Array.Copy(age, copy, age.Length);
        foreach (int i in copy)
            Console.WriteLine(i);
        Array.Clear(age, 1, 3);  // Clears elements from index 1 to index 3
        foreach (int i in age)
            Console.WriteLine(i);
        int a = Array.IndexOf(age, 30);
        int l = Array.LastIndexOf(age, 20);
        Array.Resize(ref age, 7); //5 to 7
        age[5] = 98;
        age[6] = 26;
        Console.WriteLine(age.Length);
        string result = string.Join(", ", age);

        //using System.Linq;
        Console.WriteLine(age.Contains(45));
        int sum = age.Sum();
        int min = age.Min();
        int max = age.Max();
        double avg = age.Average();
        Console.WriteLine(sum);
        Console.WriteLine(min);
        Console.WriteLine(max);
        Console.WriteLine(result);
    }
}
