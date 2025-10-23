using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Day_10___Strings
{
    internal class Day10
    {
        public static void start()
        {
            Console.WriteLine("1/22 Reverse a String");
            Console.Write("Enter string: ");
            string s = Console.ReadLine();
            StringExcercises.ReverseString(s);

            Console.WriteLine("------------------------------------");
            Console.WriteLine("2/22 Check if String is Palindrome");
            Console.Write("Enter string: ");
            s = Console.ReadLine();
            StringExcercises.IsPalindrome(s);

            Console.WriteLine("------------------------------------");
            Console.WriteLine("3/22 Count Number of Vowels in String");
            Console.Write("Enter string: ");
            s = Console.ReadLine();
            StringExcercises.CountVowels(s);

            Console.WriteLine("------------------------------------");
            Console.WriteLine("4/22 Remove Duplicates in String");
            Console.Write("Enter string: ");
            s = Console.ReadLine();
            StringExcercises.RemoveDuplicates(s);

            Console.WriteLine("------------------------------------");
            Console.WriteLine("5/22 Capitalize the First Letter of Each Word");
            Console.Write("Enter multi word string: ");
            s = Console.ReadLine();
            StringExcercises.TitleCase(s);

            Console.WriteLine("------------------------------------");
            Console.WriteLine("6/22 Remove All White Spaces from a String");
            Console.Write("Enter multi word string: ");
            s = Console.ReadLine();
            StringExcercises.RemoveWhitespaces(s);

            Console.WriteLine("------------------------------------");
            Console.WriteLine("7/22 Find the Most Frequent Character");
            Console.Write("Enter a string: ");
            s = Console.ReadLine();
            StringExcercises.FindMostFrequentChar(s);

            Console.WriteLine("------------------------------------");
            Console.WriteLine("8/22 Check if Two Strings are Anagrams: ");
            Console.Write("Enter a string: ");
            s = Console.ReadLine();
            Console.Write("Emter another string: ");
            string s2 = Console.ReadLine();
            StringExcercises.CheckIfAnagrams(s, s2);

            Console.WriteLine("------------------------------------");
            Console.WriteLine("9/22 Validate Email Address Format: ");
            Console.Write("Enter a email: ");
            s = Console.ReadLine();
            StringExcercises.ValidateEmailAddress(s);

            Console.WriteLine("------------------------------------");
            Console.WriteLine("10/22 Validate Phone Number Format: ");
            Console.Write("Enter a phone number without country code: ");
            s = Console.ReadLine();
            StringExcercises.ValidatePhoneNumber(s);

            Console.WriteLine("------------------------------------");
            Console.WriteLine("11/22 Check if a String Contains Only Digits: ");
            Console.Write("Enter a string: ");
            s = Console.ReadLine();
            StringExcercises.StringContainsOnlyDigits(s);

            Console.WriteLine("------------------------------------");
            Console.WriteLine("12/22 Password Strengh Checker: ");
            Console.Write("Enter a password: ");
            s = Console.ReadLine();
            StringExcercises.CheckPasswordStrength(s);

            Console.WriteLine("------------------------------------");
            Console.WriteLine("13/22 Extract Domain from Email Address: ");
            Console.Write("Enter a email: ");
            s = Console.ReadLine();
            StringExcercises.ExtractDomainFromEmail(s);


            Console.WriteLine("------------------------------------");
            Console.WriteLine("14/22 Mask Credit Card Numbers: ");
            Console.Write("Enter a credit card number (xxxx xxxx xxxx xxxx): ");
            s = Console.ReadLine();
            StringExcercises.MaskCreditCardNumbers(s);


            Console.WriteLine("------------------------------------");
            Console.WriteLine("15/22 Mask Email Address: ");
            Console.Write("Enter a email address: ");
            s = Console.ReadLine();
            StringExcercises.MaskEmail(s);

            Console.WriteLine("------------------------------------");
            Console.WriteLine("16/22 Extract Initials from Name: ");
            Console.Write("Enter a name with initials: ");
            s = Console.ReadLine();
            StringExcercises.ExtractInitials(s);

            Console.WriteLine("------------------------------------");
            Console.WriteLine("17/22 Extract Hashtags from Sentence: ");
            Console.Write("Enter a string with regular text and hashtags: ");
            s = Console.ReadLine();
            StringExcercises.ExtractHashtags(s);

            Console.WriteLine("------------------------------------");
            Console.WriteLine("18/22 Extract URLs from Sentence: ");
            Console.Write("Enter a string with regular text and URLs: ");
            s = Console.ReadLine();
            StringExcercises.ExtractURLs(s);

            Console.WriteLine("------------------------------------");
            Console.WriteLine("19/22 Extract Numbers from Sentence: ");
            Console.Write("Enter a string with regular text and numbers: ");
            s = Console.ReadLine();
            StringExcercises.ExtractNumbers(s);

            Console.WriteLine("------------------------------------");
            Console.WriteLine("20/22 Truncate String with Ellipsis: ");
            Console.Write("Enter a string of more than 20 characters: ");
            s = Console.ReadLine();
            StringExcercises.TruncateString(s, 10);

            Console.WriteLine("------------------------------------");
            Console.WriteLine("21/22 Highlight Keywords in a paragraph: ");
            Console.Write("Enter a string of more than 20 characters: ");
            s = Console.ReadLine();
            Console.Write("Enter number of keywords: ");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] keywords = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter keyword {i + 1}: ");
                keywords[i] = Console.ReadLine();
            }
            StringExcercises.HighlightKeywords(s, keywords);

            Console.WriteLine("------------------------------------");
            Console.WriteLine("22/22 Count Occurence of Each Word: ");
            Console.Write("Enter a string with repeating words: ");
            s = Console.ReadLine();
            StringExcercises.CountOccurence(s);



        }
    }
}
