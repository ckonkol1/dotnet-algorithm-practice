namespace Strings.Medium;

/*
 *Longest Palindromic Substring
   Write a function that, given a string, returns its longest palindromic substring.
   A palindrome is defined as a string that's written the same forward and backward. Note that single-character strings are palindromes.
   You can assume that there will only be one longest palindromic substring.

   Sample Input: wtryababcdcbauuop
   Sample Output: ababcdcba

    O(n^2) time | O(1) space - where n is the length of the input string
 */
public static class LongestPalindromicSubstring
{
    public static string GetLongestPalindromicSubstring(string str)
    {
        if (str == string.Empty)
        {
            return str;
        }

        var currentLongest = new[] { 0, 1 };

        for (var i = 1; i < str.Length; i++)
        {
            var odd = GetLongestPalindrome(str, i - 1, i + 1);
            var even = GetLongestPalindrome(str, i - 1, i);
            var longer = (odd[1] - odd[0]) > (even[1] - even[0]) ? odd : even;
            currentLongest = (longer[1] - longer[0]) > (currentLongest[1] - currentLongest[0]) ? longer : currentLongest;
        }

        return str.Substring(currentLongest[0], currentLongest[1] - currentLongest[0]);
    }

    private static int[] GetLongestPalindrome(string str, int left, int right)
    {
        while (left >= 0 && right < str.Length)
        {
            if (str[left] != str[right])
            {
                break;
            }

            left -= 1;
            right += 1;
        }

        return [left + 1, right];
    }
}