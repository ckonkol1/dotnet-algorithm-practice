using System.Text;

namespace Strings.Medium;

/*
 *Reverse Words In String
   Write a function that takes in a string of words separated by one or more whitespaces and returs a string that has these words in
   reverse order. For example, given the string "tim is great" . your function should return "great is tim".
   For this problem, a word can contain special characters. punctuation. and numbers. The words in the string will be separated by one or
   more whitespaces. and the reversed string must contain the same whitespaces as the original string. For example given the string
   4" you would be expected to retun "4 whitespaces"
   "whitespaces
   Note that you're not allowed to use any built-in split or reverse methods/functions. However. you are allowed to use a built-in
   join method/function.
   Also note that the input string isn't guaranteed to always contain words.

    Sample Input: "whitespaces    4"
    Sample Output: "4    whitespaces"
    O(n) time | O(n) space - where n is the length of the input string
 */
public static class ReverseWordsInString
{
    public static string GetReverseWordsInString(string str)
    {
        var sb = new StringBuilder();
        var count = str.Length - 1;
        while (count >= 0)
        {
            if (str[count] != ' ')
            {
                var end = count;
                while (count >= 0 && str[count] != ' ')
                {
                    count--;
                }

                sb.Append(str.Substring(count + 1, end - count));
            }
            else
            {
                var end = count;
                while (count >= 0 && str[count] == ' ')
                {
                    count--;
                }

                sb.Append(str.Substring(count + 1, end - count));
            }
        }

        return sb.ToString();
    }
}