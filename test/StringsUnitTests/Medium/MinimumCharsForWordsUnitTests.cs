using Strings.Medium;

namespace StringsUnitTests.Medium;

public class MinimumCharsForWordsUnitTests
{
    [Theory]
    [MemberData(nameof(GetTestData))]
    public void TestGetMinimumCharactersForWords(string[] input, string[] expectedResult)
    {
        var result = MinimumCharactersForWords.GetMinimumCharactersForWords(input);
        Assert.Equivalent(expectedResult, result);
    }

    public static TheoryData<string[], string[]> GetTestData
    {
        get
        {
            var data = new TheoryData<string[], string[]>();
            data.Add(["this", "that", "did", "deed", "them!", "a"], ["!", "a", "d", "d", "e", "e", "h", "i", "m", "s", "t", "t"]);
            data.Add(["apple", "plea", "lap"], ["a", "e", "l", "p", "p"]);
            data.Add(["abc", "bca", "cab"], ["a", "b", "c"]);
            data.Add(["hello", "world"], ["d", "e", "h", "l", "l", "o", "r", "w"]);
            data.Add(["a", "b", "c"], ["a", "b", "c"]);
            data.Add([""], []);
            data.Add(["test", "set", "tset"], ["e", "s", "t", "t"]);
            data.Add(["mississippi", "sip"], ["i", "i", "m", "p", "s", "s", "s"]);
            data.Add(["aaa", "aa", "a"], ["a", "a", "a"]);
            data.Add(["xyz", "xy", "z"], ["x", "y", "z"]);
            return data;
        }
    }
}