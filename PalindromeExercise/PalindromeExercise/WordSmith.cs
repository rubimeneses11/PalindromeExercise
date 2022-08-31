using System;
using System.Linq;
namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            //reverse any given word to determine if it matches original word
            //return true if matches --> IS a palindrome
            //return false if it doesn't match --> IS NOT a palindrome

            //store reversed word in a new variable
            var reversed = "";

            ////initializer: starting at the last index
            ////condition- keep looping until you've gone thru every letter of the word
            ////decrement by one letter since we are going backwards
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversed += word[i]; //reversed = reversed + word[i]
            }

            ////compare the original with the reversed word
            if (reversed.ToLower() == word.ToLower())
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}

