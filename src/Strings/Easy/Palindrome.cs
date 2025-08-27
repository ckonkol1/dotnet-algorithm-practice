namespace Strings.Easy;

/*
 * Palindrome Check
 *   Write a function that takes in a non-empty string and that returns a boolean representing whether the string is a palindrome.
 *   A palindrome is defined as a string that's written the same forward and backward. Note that single-character strings are palindromes.
 *
 *   Sample Input: abcdcba
 *   output: true
 */
public static class Palindrome
{
    public static bool IsPalindrome(string str)
    {
        var start = 0;
        var end = str.Length - 1;

        while (start < end)
        {
            if (str[start++] != str[end--])
            {
                return false;
            }
        }

        return true;
    }
}