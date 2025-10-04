using Strings.Medium;

namespace StringsUnitTests.Medium;

public class LongestPalindromicSubstringUnitTests
{
    [Theory]
    [InlineData("erwqabcdcballll", "abcdcba")]
    [InlineData("babad", "bab")]
    [InlineData("cbbd", "bb")]
    [InlineData("a", "a")]
    [InlineData("ac", "a")]
    [InlineData("forgeeksskeegfor", "geeksskeeg")]
    [InlineData("abacdfgdcaba", "aba")]
    [InlineData("abacdedcaba", "abacdedcaba")]
    [InlineData("abcde", "a")]
    [InlineData("", "")]
    public void TestIsPalindrome(string input, string expectedResult)
    {
        var result = LongestPalindromicSubstring.GetLongestPalindromicSubstring(input);
        Assert.Equal(expectedResult, result);
    }
}