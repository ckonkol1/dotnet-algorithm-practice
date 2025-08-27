using Strings.Easy;

namespace StringsUnitTests.Easy;

public class CommonCharactersUnitTests
{
    [Theory]
    [MemberData(nameof(GetCommonCharData))]
    public void TestCommonCharactersFast(string[] input, string[] expectedResult)
    {
        var result = CommonCharacters.CommonCharactersFast(input);
        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [MemberData(nameof(GetCommonCharData))]
    public void TestCommonCharactersSlow(string[] input, string[] expectedResult)
    {
        var result = CommonCharacters.CommonCharactersSlow(input);
        Assert.Equivalent(expectedResult, result);
    }

    public static IEnumerable<object[]> GetCommonCharData
    {
        get
        {
            var data = new List<object[]>
            {
                new object[] { new[] { "abc", "bcd", "cbad" }, new[] { "b", "c" } },
                new object[] { new[] { "a" }, new[] { "a" } },
                new object[] { new[] { "a", "b", "c" }, new string[] { } },
                new object[] { new[] { "aa", "aa" }, new[] { "a" } },
                new object[] { new[] { "aaaa", "a" }, new[] { "a" } },
                new object[] { new[] { "abcde", "aa", "foobar", "foobaz", "and this is a string", "aaaaaaaa", "eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeea" }, new[] { "a" } },
                new object[] { new[] { "abcdef", "fedcba", "abcefd", "aefbcd", "efadbc", "effffffffffffbcda", "eeeeeffffffbbbbbaaaaaccccdddd", "**************abdcef************" }, new[] { "a", "b", "c", "d", "e", "f" } },
                new object[]
                {
                    new[]
                    {
                        "ab&cdef!", "f!ed&cba", "a&bce!d", "ae&fb!cd", "efa&!dbc", "eff!&fff&fffffffbcda", "eeee!efff&fffbbbbbaaaaaccccdddd", "*******!***&****abdcef************", "*******!***&****a***********f*",
                        "*******!***&****b***********c*"
                    },
                    new[] { "&", "!" }
                },
                new object[] { new[] { "*abcd", "def*", "******d*****" }, new[] { "*", "d" } },
                new object[] { new[] { "*abc!d", "de!f*", "**!!!****d*****" }, new[] { "*", "!", "d" } },
            };
            return data;
        }
    }
}