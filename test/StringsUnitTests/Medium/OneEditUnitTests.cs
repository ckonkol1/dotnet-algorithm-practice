using Strings.Medium;

namespace StringsUnitTests.Medium;

public class OneEditUnitTests
{
    [Theory]
    [InlineData("pale", "ple", true)]
    [InlineData("pales", "pale", true)]
    [InlineData("pale", "bale", true)]
    [InlineData("pale", "bake", false)]
    [InlineData("abc", "abc", true)]
    [InlineData("abc", "ab", true)]
    [InlineData("abc", "a", false)]
    [InlineData("", "", true)]
    [InlineData("a", "", true)]
    [InlineData("", "a", true)]
    [InlineData("abcdef", "abqdef", true)]
    [InlineData("abcdef", "abccef", true)]
    [InlineData("abcdef", "abcde", true)]
    [InlineData("abcdef", "abdef", true)]
    [InlineData("hello", "heloos", false)]
    public void TestGetOneEdit(string inputOne, string inputTwo, bool expectedResult)
    {
        var result = OneEdit.GetOneEdit(inputOne, inputTwo);
        Assert.Equal(expectedResult, result);
    }
}