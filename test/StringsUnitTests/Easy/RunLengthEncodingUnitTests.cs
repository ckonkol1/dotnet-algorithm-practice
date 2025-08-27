using Strings.Easy;

namespace StringsUnitTests.Easy;

public class RunLengthEncodingUnitTests
{
    [Theory]
    [InlineData("AAAAAAAAAAAAABBCCCCDD", "9A4A2B4C2D")]
    [InlineData("aA", "1a1A")]
    [InlineData("122333", "112233")]
    [InlineData("************^^^^^^^$$$$$$%%%%%%%!!!!!!AAAAAAAAAAAAAAAAAAAA", "9*3*7^6$7%6!9A9A2A")]
    [InlineData("aAaAaaaaaAaaaAAAABbbbBBBB", "1a1A1a1A5a1A3a4A1B3b4B")]
    [InlineData("                          ", "9 9 8 ")]
    [InlineData("1  222 333    444  555", "112 321 334 342 35")]
    [InlineData("1A2BB3CCC4DDDD", "111A122B133C144D")]
    [InlineData("........______=========AAAA   AAABBBB   BBB", "8.6_9=4A3 3A4B3 3B")]
    [InlineData("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",
        "9a9a9a9a9a9a9a9a9a9a9a9a9a9a9a9a9a9a9a9a9a9a9a1a")]
    [InlineData("        aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "8 9a9a9a9a9a4a")]
    [InlineData(" ", "1 ")]
    [InlineData("[(aaaaaaa,bbbbbbb,ccccc,dddddd)]", "1[1(7a1,7b1,5c1,6d1)1]")]
    [InlineData(";;;;;;;;;;;;''''''''''''''''''''1233333332222211112222111s", "9;3;9'9'2'111273524142311s")]
    [InlineData("AAAAAAAAAAAAABBCCCCDDDDDDDDDDD", "9A4A2B4C9D2D")]
    public void TestRunLengthEncodingFast(string input, string expectedResult)
    {
        var result = RunLengthEncoding.RunLengthEncodingFast(input);
        Assert.Equal(expectedResult, result);
    }
}