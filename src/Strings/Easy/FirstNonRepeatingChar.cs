namespace Strings.Easy;

/*
 * First Non-Repeating Character
   Write a function that takes in a string of lowercase English-alphabet letters and returns
   the index of the string's first non-repeating character.
   The first non-repeating character is the first character in a string that occurs only once.
   If the input string doesn't have any non-repeating characters, your function should return -1 .
   Sample Input: string = "abcdcaf"
   Sample Output: 1  // The first non-repeating character is "b" and is found at index 1.
 */

public static class FirstNonRepeatingChar
{
    public static int FirstNonRepeatingCharacterWithLinq(string str)
    {
        var newStr = new string(str.GroupBy(c => c)
            .Where(g => g.Count() == 1)
            .Select(g => g.Key)
            .ToArray());

        if (newStr.Length > 0)
        {
            return str.IndexOf(newStr[0]);
        }

        return -1;
    }

    //Space and Time Complexity: O(n) time | O(1) space
    public static int FirstNonRepeatingCharacter(string str)
    {
        var dict = new Dictionary<char, int>();
        foreach (var c in str.Where(c => !dict.TryAdd(c, 1)))
        {
            dict[c]++;
        }

        foreach (var item in dict.Where(item => item.Value == 1))
        {
            return str.IndexOf(item.Key);
        }

        return -1;
    }
}