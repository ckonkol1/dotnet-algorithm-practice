using Strings.Medium;

namespace StringsUnitTests.Medium;

public class ReverseWordsInStringUnitTests
{
    [Theory]
    [InlineData("hello world", "world hello")]
    [InlineData("a b c", "c b a")]
    [InlineData("single", "single")]
    [InlineData("", "")]
    [InlineData("  leading spaces", "spaces leading  ")]
    [InlineData("trailing spaces  ", "  spaces trailing")]
    [InlineData("  multiple   spaces  between words  ", "  words between  spaces   multiple  ")]
    [InlineData("punctuation!", "punctuation!")]
    [InlineData("word1, word2.", "word2. word1,")]
    public void TestGetReverseWordsInString(string input, string expectedResult)
    {
        var result = ReverseWordsInString.GetReverseWordsInString(input);
        Assert.Equal(expectedResult, result);
    }
}