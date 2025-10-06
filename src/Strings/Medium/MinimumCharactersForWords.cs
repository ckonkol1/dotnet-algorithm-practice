namespace Strings.Medium;

/*
 *Minimum Characters For Words
   Write a function that takes in an array of words and returns the smallest array of characters needed to form all of the
   words. The characters don't need to be in any particular order.
   For example, the characters ["y","o","r","u"] are needed to form the words ["your", "you", "or", "yo"].

   Note: the input words won't contain any spaces; however, they might contain punctuation and/or special characters.

   Sample Input: words = ["this", "that", "did", "deed", "them!", "a"]
    Sample Output: ["t", "t", "h", "i", "s", "a", "d", "d", "e", "e", "m", "!"]

        O(w * c) time | O(c) space - where w is the number of words and c is the number of unique characters across all words
 */
public static class MinimumCharactersForWords
{
    public static string[] GetMinimumCharactersForWords(string[] words)
    {
        var result = new List<string>();
        var maxFreq = new Dictionary<char, int>();
        foreach (var word in words)
        {
            var localFreq = new Dictionary<char, int>();
            foreach (var c in word)
            {
                if (!localFreq.TryAdd(c, 1))
                    localFreq[c]++;
            }

            foreach (var c in localFreq)
            {
                if (!maxFreq.ContainsKey(c.Key) || c.Value > maxFreq[c.Key])
                {
                    maxFreq[c.Key] = localFreq[c.Key];
                }
            }
        }

        foreach (var c in maxFreq)
        {
            for (var i = 0; i < c.Value; i++)
            {
                result.Add(c.Key.ToString());
            }
        }

        return result.ToArray();
    }
}