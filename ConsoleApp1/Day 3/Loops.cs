using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Loops
    {
           
        public static void SumOfNumbers(int target)
        {
            int total = 0;
            for (int i = 1; i <= target; i++)
            {
                total += i;
            }
            Console.WriteLine($"The sum of numbers from 1 to {target} is: {total}");
        }

        public static void EvenNumbersUsingDoWhile()
        {
            int num = 2;

            do
            {
                Console.Write($"{num} ");
                num += 2;
            } while (num <= 100);

        }

        public static void SumAndCountOfEvenNumbers(int target)
        {
            int sum = 0;
            int evenCount = 0;
            
            for (int i = 1; i <= target; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                    evenCount++;
                }
            }

            Console.WriteLine($"The sum of even numbers from 1 to {target} is: {sum}, there are {evenCount} even numbers from 1 to {target}");
        }

        public static void MultiplicationTable(int targetNumber)
        {
            Console.WriteLine($"Printing 1 to {targetNumber} tables.");

            for (int i = 1; i <= targetNumber; i++)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine($"Table for {i}:");
                Console.WriteLine("--------------------------------");
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
                Console.WriteLine("--------------------------------");
            }
            
        }

        public static void SumOfDigits(int num)
        {
            int sum = 0;
            int copy = num;
            
            while (num > 0)
            {
                int lastDigit = num % 10;
                sum += lastDigit;
                num /= 10;
            }

            Console.WriteLine($"The sum of digits of {copy} is: {sum}");

        }

        public static void Palindrome(string word)
        {
            string reversed = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversed += word[i];
            }

            if (word.Equals(reversed))
            {
                Console.WriteLine($"{word} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"{word} is not a palindrome.");
            }
        }

        public static void SpyNumber(int num)
        {
            int sum = 0;
            int product = 1;
            int copy = num - 1 + 1;

            while (num > 0)
            {
                int lastDigit = num % 10;
                sum += lastDigit;
                product *= lastDigit;
                num /= 10;
            }

            if (sum == product)
            {
                Console.WriteLine($"{copy} is a spy number since sum of digits ({sum}) is equal to product of digits ({product}).");
            }
            else
            {
                Console.WriteLine($"{copy} is not a spy number since sum of digits ({sum}) is not equal to the product of digits ({product}).");
            }
        }

        public static void StrongNumber(int num)
        {
            int sumOfFactorial = 0;
            int copy = num;

            while (num > 0)
            {
                int lastDigit = num % 10;
                sumOfFactorial += Helper_Factorial(lastDigit);
                num /= 10;
            }

            if (copy == sumOfFactorial)
            {
                Console.WriteLine($"{copy} is a strong number since sum of factorial of digits ({sumOfFactorial}) is equal to the number itself ({copy}).");
            }
            else
            {
                Console.WriteLine($"{copy} is not a strong number since sum of factorial of digits ({sumOfFactorial}) is not equal to the number itself ({copy}).");
            }
        }

        public static void PerfectNumber(int num)
        {
            // (sum of its proper divisors equals the number
            int sumOfDivisors = 0;
            int copy = num;

            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    sumOfDivisors += i;
                }
            }

            if (sumOfDivisors == copy)
            {
                Console.WriteLine($"{copy} is a perfect number since sum of its proper divisors ({sumOfDivisors}) equals the number itself ({copy}).");
            }
            else
            {
                Console.WriteLine($"{copy} is not a perfect number since sum of its proper divisors ({sumOfDivisors}) does not equal the number itself ({copy}).");
            }

        }

        public static void HarshadNumber(int num)
        {
            int sum = 0;
            int copy = num;

            while (num > 0)
            {
                int lastDigit = num % 10;
                sum += lastDigit;
                num /= 10;
            }

            if (copy % sum == 0)
            {
                Console.WriteLine($"{copy} is a Harshad number since the number is divisible by sum of digits ({sum}).");
            }
            else
            {
                Console.WriteLine($"{copy} is not a Harshad number since the number is not divisible by sum of its digits ({sum}).");
            }
        }

        public static void NeonNumber(int num)
        {
            int sumOfSquareOfDigits = 0;
            int square = num * num;
            int copy = square;

            while (square > 0)
            {
                int lastDigit = square % 10;
                sumOfSquareOfDigits += lastDigit;
                square /= 10;
            }

            if (sumOfSquareOfDigits == num)
            {
                Console.WriteLine($"{num} is a Neon number since sum of digits of square of number ({copy}) equals the number itself ({num}).");
            }
            else
            {
                Console.WriteLine($"{num} is not a Neon number since sum of digits of square of number ({copy}) does not equal the number itself ({num}).");
            }
        }

        public static void AutomorphicNumber(int num)
        {
            int square = num * num;

            if (Helper_NumberEndsWith(square, num))
            {
                Console.WriteLine($"{num} is automorphic since square of number ({square}) ends with num itself.");
            }
            else
            {
                Console.WriteLine($"{num} is not an automorphic since square of number ({square}) does not end with num itself.");
            }
        }


        // Helper functions.
        public static int Helper_Factorial(int num)
        {
            int res = num;

            for (int i = num - 1; i >= 2; i--)
            {
                res *= i;
            }

            return res;

        }

        public static bool Helper_NumberEndsWith(int bigNumber, int endsWith)
        {
            /*
             * say the small number is 25. so we need last 2 digits of bigNumber, wihch means % with 100. 1__ 2 digits.
             * say small number is 625, now we need 3 last digits, so % with 1000. 3 zeroes.
             * direct correlation between smallnumber number of digits and number of zeroes.
             */

            int endsWithCopy = endsWith;
            int digits = 0;

            while (endsWith > 0)
            {
                digits += 1;
                endsWith /= 10;
            }
            //Console.WriteLine($"{endsWithCopy} has {digits} digits");
            int moduleDivider = (int) Math.Pow(10, digits);
            //Console.WriteLine($"Divisor is {moduleDivider}");
            int lastNeededDigits = bigNumber % moduleDivider;
            //Console.WriteLine($"Last {digits} digits of big number is {lastNeededDigits}");

            return lastNeededDigits == endsWithCopy;
        }

    }
}
