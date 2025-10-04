namespace Strings.Medium;

/*
 *Group Anagrams
   Write a function that takes in an array of strings and groups anagrams together.
   Anagrams are strings made up of exactly the same letters, where order doesn't matter.
   For example, "cinema" and "iceman" are anagrams; similarly, "foo" and "ofo" are anagrams.
   Your function should return a list of anagram groups in no particular order.

   Sample Input: words = ["yo", "act", "flop", "tac", "foo", "cat", "oy", "olfp"]
    Sample Output: [["yo", "oy"], ["flop", "olfp"], ["act", "tac", "cat"], ["foo"]]

     O(n * m log(m)) time | O(n * m) space - where n is the number of words and m is the length of the longest word
 */
public class GroupAnagrams
{
    public static List<List<string>> GetGroupAnagrams(List<string> words)
    {
        var groups = new Dictionary<string, List<string>>();

        foreach (var word in words)
        {
            var chars = word.ToCharArray();
            Array.Sort(chars);
            var sortedKey = new string(chars);

            if (!groups.TryGetValue(sortedKey, out var group))
            {
                group = [];
                groups[sortedKey] = group;
            }

            group.Add(word);
        }

        return groups.Values.ToList();
    }
}