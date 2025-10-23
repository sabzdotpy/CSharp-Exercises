using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleApp1.Day_10___Strings
{
    internal class StringExcercises
    {
        public static void ReverseString(string str)
        {
            if (str == null)
            {
                return;
            }

            string x = new string(str.Reverse().ToArray());
            Console.WriteLine(x);
        }

        public static void IsPalindrome(string s)
        {
            string reversed = new string(s.Reverse().ToArray());
            Console.WriteLine((s == reversed) ? $"{s} is a palindrome." : $"{s} is not a palindrome.");
        }

        public static void CountVowels(string s)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            int count = 0;

            foreach (char letter in s)
            {
                if (vowels.Contains(letter))
                {
                    count++;
                }
            }

            Console.WriteLine($"{s} has {count} vowels.");
        }

        public static void RemoveDuplicates(string s)
        {
            HashSet<char> seen = [];
            string newStr = "";

            foreach (char letter in s)
            {
                if (!seen.Contains(letter))
                {
                    newStr += letter;
                    seen.Add(letter);
                }
            }

            Console.WriteLine($"{s} with duplicates removed is {newStr}");
        }

        public static void TitleCase(string s)
        {
            string[] split = s.Split(" ");
            string[] final = new string[split.Length];

            for (int i = 0; i < split.Length; i++)
            {
                string word = split[i];
                string titleCased = string.Concat(word.ElementAt(0).ToString().ToUpperInvariant(), word.AsSpan(1));
                final[i] = titleCased;
            }

            Console.WriteLine($"{s} -> {string.Join(" ", final)}.");
        }

        public static void RemoveWhitespaces(string s)
        {
            string[] split = s.Split(" ");
            Console.WriteLine($"{s} -> {string.Join("", split)}.");
        }

        public static void FindMostFrequentChar(string s)
        {
            Dictionary<char, int> frequency = [];

            foreach (char letter in s)
            {
                frequency[letter] = frequency.GetValueOrDefault(letter, 0) + 1;
            }

            int maxFreq = -99;
            char maxLetter = 'x';
            foreach (KeyValuePair<char, int> item in frequency)
            {
                if (item.Value > maxFreq)
                {
                    maxFreq = item.Value;
                    maxLetter = item.Key;
                }
            }

            Console.WriteLine($"{maxLetter} is the most frequent letter with a frequency of {maxFreq}");
        }

        public static void CheckIfAnagrams(string s1, string s2)
        {
            if (s1.Length != s2.Length)
            {
                Console.WriteLine("Not anagrams.");
                return;
            }

            Dictionary<char, int> freq = [];

            foreach (char letter in s1)
            {
                freq[letter] = freq.GetValueOrDefault(letter, 0) + 1;
            }

            foreach (char letter in s2)
            {
                if (!freq.ContainsKey(letter))
                {
                    // this letter is not in prev string. so false
                    Console.WriteLine("Not anagrams.");
                    return;
                }

                freq[letter]--;
                if (freq[letter] == 0) freq.Remove(letter);
                // this will make sure for each letter which is in 1,
                // if its in 2, its removed, so if letters are balanced (i.e. s1.freq(letter) == s2.freq(letter), it will be rmoved.
                // only unbalanced letters will remain, unbalanced = not anagram.
            }

            Console.WriteLine( (freq.Count > 0) ? "Not anagrams." : "Anagrams" );

        }

        public static void ValidateEmailAddress(string email)
        {
            email = email.Trim();

            if (email.Length == 0)
            {
                Console.WriteLine("Invalid");
                return;
            }

            if (!email.Contains("@") || !email.Contains("."))
            {
                Console.WriteLine("Invalid");
                return;
            }

            Console.WriteLine("Valid email");
        }

        public static void ValidatePhoneNumber(string phoneNumber)
        {
            phoneNumber = phoneNumber.Trim();

            if (phoneNumber.Length != 10)
            {
                Console.WriteLine("Invalid.");
                return;
            }

            Console.WriteLine("Valid");
        }

        public static void StringContainsOnlyDigits(string s)
        {
            Console.WriteLine(s.All(char.IsDigit) ? $"{s} is all digits" : $"{s} is not all digits.");
        }

        public static void CheckPasswordStrength(string password)
        {
            int strength = 0;

            if (password.Length > 6) strength++;
            if (password.Any(char.IsDigit)) strength++;
            if (password.Any(char.IsAsciiLetterUpper))  strength++;
            if (password.Any(char.IsAsciiLetterLower)) strength++;
            if (password.Any(char.IsSymbol)) strength++;

            switch (strength)
            {
                case int x when x >= 5:
                    Console.WriteLine("Password is very strong.");
                    break;
                case int x when x > 3:
                    Console.WriteLine("Password is moderately strong.");
                    break;
                default:
                    Console.WriteLine("Password is weak");
                    break;
            }
        }

        public static void ExtractDomainFromEmail(string email)
        {
            if (email == null) return;

            string[] parts = email.Split("@");
            string domain = parts[1];
            Console.WriteLine($"Domain: {domain}");
        }

        public static void MaskCreditCardNumbers(string number)
        {
            if (number.Length != 19)
            {
                Console.WriteLine("Invalid credit card number entered. Card number must be of 16 digts with 3 spaces");
            }

            Console.Write("Masked Number: **** **** **** ");
            Console.WriteLine(number.Substring(15));
        }

        public static void MaskEmail(string email)
        {
            if (email == null) return;
            string[] parts = email.Split("@");

            Console.Write($"Masked Email: {parts[0].Substring(0, 2)}***@");
            Console.WriteLine($"{parts[1][0]}***.{parts[1].Split(".")[1]}");
        }
        
        public static void ExtractInitials(string s)
        {
            Console.Write("Initials: ");
            string[] parts = s.Split(".");

            foreach (string part in parts)
            {
                if (part.Length == 1)
                {
                    Console.Write($"{part}. ");
                }
            }
            Console.WriteLine();
        }

        public static void ExtractHashtags(string sentence)
        {
            Console.Write("Hashtags: ");
            string[] parts = sentence.Split(" ");

            foreach (string part in parts)
            {
                if (part.StartsWith("#"))
                {
                    Console.Write($"{part}, ");
                }
            }
            Console.WriteLine();
        }


        public static void ExtractURLs(string sentence)
        {
            Console.Write("URLs: ");
            string[] parts = sentence.Split(" ");

            foreach (string part in parts)
            {
                if (part.StartsWith("http") || part.StartsWith("www"))
                {
                    Console.Write($"{part}, ");
                }
            }
            Console.WriteLine();
        }

        public static void ExtractNumbers(string sentence)
        {
            Console.Write("Numbers: ");
            string[] parts = sentence.Split(" ");

            foreach (string part in parts)
            {
                if ( part.All(char.IsDigit) )
                {
                    Console.Write($"{part}, ");
                }
            }
            Console.WriteLine();
        }

        public static void TruncateString(string text, int length = 20)
        {
            Console.WriteLine( text.Substring(0, length) + "..." );
        }

        // highlight keywords
        public static void HighlightKeywords(string text, string[] keywords)
        {
            string[] parts = text.Split(" ");
            Console.WriteLine("Highlighted: ");
            foreach (string word in parts)
            {
                if (keywords.Contains(word))
                {
                    Console.Write($"<div>{word}</div> ");
                }
                else
                {
                    Console.Write($"{word} ");
                }
            }
            Console.WriteLine();
        }

        public static void CountOccurence(string s)
        {
            string[] parts = s.Split(" ");
            Dictionary<string, int> freq = [];

            foreach (string word in parts)
            {
                freq[word] = freq.GetValueOrDefault(word, 0) + 1;
            }

            Console.WriteLine("Occurences: ");
            Console.WriteLine(JsonSerializer.Serialize(freq));
        }
    }
}
