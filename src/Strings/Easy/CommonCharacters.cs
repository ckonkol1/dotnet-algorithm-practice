namespace Strings.Easy;

/*
 * Common Characters
   Write a function that takes in a non-empty list of non-empty strings and returns a list of characters that are common to all strings in the
   list ignoring multiplicity.
   Note that the strings are not guaranteed to only contain alphanumeric characters. The list you return can be in any order.

   Sample Input: strings   = ["abc", "bcd", "cbaccd"]
   Sample Output: ["b", "c"] // The characters could be ordered differently.
 */
public static class CommonCharacters
{
    public static string[] CommonCharactersSlow(string[] strings)
    {
        var charCount = new Dictionary<char, int>()
        {
        };
        var result = new List<string>();
        foreach (var s in strings)
        {
            var charSet = s.Distinct().ToArray();
            foreach (var c in charSet)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c] += 1;
                }
                else
                {
                    charCount.TryAdd(c, 1);
                }

                if (charCount[c] == strings.Length)
                {
                    result.Add(c.ToString());
                }
            }
        }

        return result.ToArray();
    }

    public static string[] CommonCharactersFast(string[] strings)
    {
        var charSet = new HashSet<char>(strings[0]);
        foreach (var s in strings)
        {
            var currentSet = new HashSet<char>(s);
            charSet.IntersectWith(currentSet);
        }

        return charSet.Select(c => c.ToString()).ToArray();
    }
}