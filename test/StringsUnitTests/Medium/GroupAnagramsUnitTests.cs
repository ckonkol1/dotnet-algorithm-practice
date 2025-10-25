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
            var data = new TheoryData<List<string>, List<List<string>>>
            {
                {
                    ["eat", "tea", "tan", "ate", "nat", "bat"],
                    [
                        ["eat", "tea", "ate"],
                        ["tan", "nat"],
                        ["bat"]
                    ]
                },
                {
                    ["a", "b", "a"],
                    [
                        ["a", "a"],
                        ["b"]
                    ]
                },
                {
                    [""],
                    [[""]]
                },
                {
                    ["abc", "def", "ghi"],
                    [
                        ["abc"],
                        ["def"],
                        ["ghi"]
                    ]
                },
                {
                    [],
                    []
                },
                {
                    ["listen", "silent", "hello", "world"],
                    [
                        ["listen", "silent"],
                        ["hello"],
                        ["world"]
                    ]
                }
            };
            return data;
        }
    }
}