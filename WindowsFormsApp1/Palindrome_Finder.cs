using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace WindowsFormsApp1
{
    public class Palindrome_Finder
    {
        String input;
        String longestPalindrome = "";

        public Palindrome_Finder(String input)
        {
            this.input = input;
        }

        public bool checkIfPalindrome()
        {
            //For use in array indexing, length is 1 indexed while arrays are 0 indexed. Correct for this by subtracting one from the length field
            int length = input.Length - 1;

            //We will only look at half the characters to see if the word is a palindrome.
            int iterationMax = input.Length / 2;

            for (int i = 0; i < iterationMax; i++)
            {
                Debug.Print("Checking indexes: " + i.ToString() + " And: " + (length-i).ToString());
                if (input[i] != input[length - i])
                {
                    Debug.Print("Is not Palindrome");
                    return false;
                }
            }
            Debug.Print("Is Palindrome");
            return true;
        }

        public String findLargestPalindrome()
        {
            //if input is only one character long the longest palindrome is just that character. If the string is empty than return ""
            if(input.Length <= 1)
            {
                Debug.Print("The longest Palindrome is: " + input);
                return input;
            }

            //For use in array indexing, length is 1 indexed while arrays are 0 indexed. Correct for this by subtracting one from the length field
            int length = input.Length - 1;

            //We will start looking at the center of the input and move to the left and right edges of the array from there
            int startingPoint = input.Length / 2;

            //first we will look for odd-sized palindromes
            for(int i = startingPoint, timesIterated = 0, direction = 1;
                (timesIterated < length) && ((longestPalindrome.Length - 1) <= (length - timesIterated));
                timesIterated++, i += direction * timesIterated, direction *= -1)
            {
                int leftIndex = i - 1, rightIndex = i + 1;
                if (leftIndex < 0) leftIndex = 0;
                if (rightIndex > length) rightIndex = length;

                int rightBound = 0;
                int leftBound = 0;

                for (bool continueFlag = true; leftIndex >= 0 && rightIndex <= length && continueFlag == true;)
                {
                    if (input[leftIndex] == input[rightIndex])
                    {
                        rightBound = rightIndex;
                        leftBound = leftIndex;
                        rightIndex++;
                        leftIndex--;
                    }
                    else
                    {
                        continueFlag = false;
                    }

                }

                String palindromeFound = input.Substring(leftBound, (rightBound - leftBound + 1));
                if (palindromeFound.Length > longestPalindrome.Length)
                {
                    longestPalindrome = palindromeFound;
                }
            }

            //Next we will look for even-sized palindromes
            for (int i = startingPoint, timesIterated = 0, direction = 1;
                (timesIterated < length) && ((longestPalindrome.Length - 1) <= (length - timesIterated));
                timesIterated++, i += direction * timesIterated, direction *= -1)
            {
                int leftIndex = i, rightIndex = i + 1;
                if (leftIndex < 0) leftIndex = 0;
                if (rightIndex > length) rightIndex = length;

                int rightBound = 0;
                int leftBound = 0;

                for (bool continueFlag = true; leftIndex >= 0 && rightIndex <= length && continueFlag == true;)
                {
                    if (input[leftIndex] == input[rightIndex])
                    {
                        rightBound = rightIndex;
                        leftBound = leftIndex;
                        rightIndex++;
                        leftIndex--;
                    }
                    else
                    {
                        continueFlag = false;
                    }

                }

                String palindromeFound = input.Substring(leftBound, (rightBound - leftBound + 1));
                if (palindromeFound.Length > longestPalindrome.Length)
                {
                    longestPalindrome = palindromeFound;
                }
            }

            Debug.Print("The longest Palindrome is: " + longestPalindrome);
            return longestPalindrome;
        }

    }
}
