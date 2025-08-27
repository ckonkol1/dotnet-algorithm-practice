using Strings.Easy;

namespace StringsUnitTests.Easy;

public class PalindromeUnitTests
{
    [Theory]
    [InlineData("abcdcba", true)]
    [InlineData("a", true)]
    [InlineData("ab", false)]
    [InlineData("aba", true)]
    [InlineData("abb", false)]
    [InlineData("abba", true)]
    [InlineData("abcdefghhgfedcba", true)]
    [InlineData("abcdefghihgfedcba", true)]
    [InlineData("abcdefghihgfeddcba", false)]
    public void TestIsPalindrome(string input, bool expectedResult)
    {
        var result = Palindrome.IsPalindrome(input);
        Assert.Equal(expectedResult, result);
    }
}