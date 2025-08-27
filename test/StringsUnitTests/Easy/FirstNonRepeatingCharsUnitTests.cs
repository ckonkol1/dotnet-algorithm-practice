using Strings.Easy;

namespace StringsUnitTests.Easy;

public class FirstNonRepeatingCharsUnitTests
{
    [Theory]
    [InlineData("abcdcaf", 1)]
    [InlineData("faadabcbbebdf", 6)]
    [InlineData("a", 0)]
    [InlineData("ab", 0)]
    [InlineData("abc", 0)]
    [InlineData("abac", 1)]
    [InlineData("ababac", 5)]
    [InlineData("ababacc", -1)]
    [InlineData("lmnopqldsafmnopqsa", 7)]
    [InlineData("abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxy", 25)]
    [InlineData("abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz", -1)]
    [InlineData("", -1)]
    [InlineData("ggyllaylacrhdzedddjsc", 10)]
    [InlineData("aaaaaaaaaaaaaaaaaaaabbbbbbbbbbcccccccccccdddddddddddeeeeeeeeffghgh", -1)]
    [InlineData("aabbccddeeff", -1)]
    public void TestFirstNonRepeatingCharacter(string input, int expectedResult)
    {
        var result = FirstNonRepeatingChar.FirstNonRepeatingCharacter(input);
        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [InlineData("abcdcaf", 1)]
    [InlineData("faadabcbbebdf", 6)]
    [InlineData("a", 0)]
    [InlineData("ab", 0)]
    [InlineData("abc", 0)]
    [InlineData("abac", 1)]
    [InlineData("ababac", 5)]
    [InlineData("ababacc", -1)]
    [InlineData("lmnopqldsafmnopqsa", 7)]
    [InlineData("abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxy", 25)]
    [InlineData("abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz", -1)]
    [InlineData("", -1)]
    [InlineData("ggyllaylacrhdzedddjsc", 10)]
    [InlineData("aaaaaaaaaaaaaaaaaaaabbbbbbbbbbcccccccccccdddddddddddeeeeeeeeffghgh", -1)]
    [InlineData("aabbccddeeff", -1)]
    public void TestFirstNonRepeatingCharacterLinq(string input, int expectedResult)
    {
        var result = FirstNonRepeatingChar.FirstNonRepeatingCharacterWithLinq(input);
        Assert.Equal(expectedResult, result);
    }
}