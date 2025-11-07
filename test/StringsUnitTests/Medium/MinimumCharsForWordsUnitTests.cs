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
            var data = new TheoryData<string[], string[]>
            {
                { ["this", "that", "did", "deed", "them!", "a"], ["!", "a", "d", "d", "e", "e", "h", "i", "m", "s", "t", "t"] },
                { ["apple", "plea", "lap"], ["a", "e", "l", "p", "p"] },
                { ["abc", "bca", "cab"], ["a", "b", "c"] },
                { ["hello", "world"], ["d", "e", "h", "l", "l", "o", "r", "w"] },
                { ["a", "b", "c"], ["a", "b", "c"] },
                { [""], [] },
                { ["test", "set", "tset"], ["e", "s", "t", "t"] },
                { ["mississippi", "sip"], ["i", "i", "m", "p", "s", "s", "s"] },
                { ["aaa", "aa", "a"], ["a", "a", "a"] },
                { ["xyz", "xy", "z"], ["x", "y", "z"] }
            };
            return data;
        }
    }
}