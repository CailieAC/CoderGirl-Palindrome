using System;

namespace Palindrome
{
    public static class Program
    {
        public static void Main()
        {
            Console.Write("Enter a word to check for palindrome: ");
            string userInput = Console.ReadLine();
            Console.WriteLine(IsPalindrome(userInput));

            Console.ReadLine();
        }

        // TODO: Create a method that recognizes palindromes.
        // The name of the method you create should be IsPalindrome
        // The method should take a string as the input.
        // The method should return a bool - true if the input is a palindrome and false if it is not.
        public static bool IsPalindrome(string userInput)
        {
            bool isWordPalindrome = false;

            char[] inputArray = userInput.ToCharArray();
            
            Array.Reverse(inputArray);
            string reversedUserInput = String.Concat(inputArray);

            if (String.Equals(userInput.ToLower(), reversedUserInput.ToLower()))
                isWordPalindrome = true;

            return isWordPalindrome;
        }
    }
}
