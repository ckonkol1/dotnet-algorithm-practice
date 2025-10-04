namespace Strings.Medium;

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