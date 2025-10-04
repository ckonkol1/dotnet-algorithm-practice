using Strings.Medium;

namespace StringsUnitTests.Medium;

public class GroupAnagramsUnitTests
{
    [Theory]
    [MemberData(nameof(GetTestData))]
    public void TestGetGroupAnagrams(List<string> input, List<List<string>> expectedResult)
    {
        var result = GroupAnagrams.GetGroupAnagrams(input);
        Assert.Equivalent(expectedResult, result);
    }

    public static TheoryData<List<string>, List<List<string>>> GetTestData
    {
        get
        {
            var data = new TheoryData<List<string>, List<List<string>>>();
            data.Add(
                ["eat", "tea", "tan", "ate", "nat", "bat"],
                [
                    new List<string> { "eat", "tea", "ate" },
                    new List<string> { "tan", "nat" },
                    new List<string> { "bat" }
                ]
            );
            data.Add(
                ["a", "b", "a"],
                [
                    new List<string> { "a", "a" },
                    new List<string> { "b" }
                ]
            );
            data.Add(
                [""],
                [new List<string> { "" }]
            );
            data.Add(
                ["abc", "def", "ghi"],
                [
                    new List<string> { "abc" },
                    new List<string> { "def" },
                    new List<string> { "ghi" }
                ]
            );
            data.Add(
                [],
                []
            );
            data.Add(
                ["listen", "silent", "hello", "world"],
                [
                    new List<string> { "listen", "silent" },
                    new List<string> { "hello" },
                    new List<string> { "world" }
                ]
            );
            return data;
        }
    }
}