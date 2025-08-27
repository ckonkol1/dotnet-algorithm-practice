using System.Text;

namespace Strings.Easy;

/*
 *Semordnilap
   Write a function that takes in a list of unique strings and returns a list of semordnilap pairs.
   A semordnilap pair is defined as a set of different strings where the reverse of one word is the same as the forward
   version of the other. For example the words "diaper" and "repaid" are a semordnilap pair, as are the words
   "palindromes" and "semordnilap".
   The order of the returned pairs and the order of the strings within each pair does not matter.
   [ ["diaper", "repaid"], ["abc", "cba"]]

   Sample Input: words = ["diaper", "abc", "test", "cba", "repaid"]
   Sample Output: [["diaper", "repaid"], ["abc", "cba"]]
 */
public static class Semordnilap
{
    public static List<List<string>> SemordnilapFast(string[] words)
    {
        var result = new List<List<string>>();
        var originalSet = new HashSet<string>(words);

        foreach (var word in words)
        {
            var sb = new StringBuilder(word.Length);
            for (var i = word.Length - 1; i >= 0; i--)
            {
                sb.Append(word[i]);
            }

            var reversed = sb.ToString();
            if (originalSet.Contains(reversed))
            {
                originalSet.Remove(reversed);
                originalSet.Remove(word);
                result.Add([word, reversed]);
            }
        }

        return result;
    }
}