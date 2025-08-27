using Strings.Easy;

namespace StringsUnitTests.Easy;

public class SemordnilapUnitTests
{
    [Theory]
    [MemberData(nameof(GetSemordnilapData))]
    public void TestSemordnilapFast(string[] input, List<List<string>> expectedResult)
    {
        var result = Semordnilap.SemordnilapFast(input);
        Assert.Equivalent(expectedResult, result);
    }

    public static IEnumerable<object[]> GetSemordnilapData
    {
        get
        {
            var data = new List<object[]>
            {
                new object[] { new string[] { }, new List<List<string>>() { } },
                new object[] { new[] { "aaa", "bbbb" }, new List<List<string>>() { } },
                new object[] { new[] { "dog", "god" }, new List<List<string>>() { new List<string>() { "dog", "god" } } },
                new object[] { new[] { "dog", "hello", "god" }, new List<List<string>>() { new List<string>() { "dog", "god" } } },
                new object[] { new[] { "dog", "desserts", "god", "stressed" }, new List<List<string>>() { new List<string>() { "dog", "god" }, new List<string>() { "desserts", "stressed" } } },
                new object[] { new[] { "dog", "hello", "desserts", "test", "god", "stressed" }, new List<List<string>>() { new List<string>() { "dog", "god" }, new List<string>() { "desserts", "stressed" } } },
                new object[] { new[] { "abcde", "edcba", "edbc", "edb", "cbde", "abc" }, new List<List<string>>() { new List<string>() { "abcde", "edcba" }, new List<string>() { "cbde", "edbc" } } },
                new object[] { new[] { "abcde", "bcd", "dcb", "edcba", "aaa" }, new List<List<string>>() { new List<string>() { "abcde", "edcba" }, new List<string>() { "bcd", "dcb" } } },
                new object[] { new[] { "abcdefghijk", "aaa", "hello", "racecar", "kjihgfedcba" }, new List<List<string>>() { new List<string>() { "abcdefghijk", "kjihgfedcba" } } },
                new object[]
                {
                    new[] { "liver", "dog", "hello", "desserts", "evil", "test", "god", "stressed", "racecar", "palindromes", "semordnilap", "abcd", "live" },
                    new List<List<string>>() { new List<string>() { "dog", "god" }, new List<string>() { "desserts", "stressed" }, new List<string>() { "evil", "live" }, new List<string>() { "palindromes", "semordnilap" } }
                },
            };
            return data;
        }
    }
}