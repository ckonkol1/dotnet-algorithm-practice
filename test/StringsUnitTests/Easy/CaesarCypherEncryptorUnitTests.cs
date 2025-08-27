using Strings.Easy;

namespace StringsUnitTests.Easy;

public class CaesarCypherEncryptorUnitTests
{
    [Theory]
    [InlineData("xyz", 2, "zab")]
    [InlineData("abc", 0, "abc")]
    [InlineData("abc", 3, "def")]
    [InlineData("xyz", 5, "cde")]
    [InlineData("abc", 26, "abc")]
    [InlineData("abc", 52, "abc")]
    [InlineData("abc", 57, "fgh")]
    [InlineData("xyz", 25, "wxy")]
    [InlineData("iwufqnkqkqoolxzzlzihqfm", 25, "hvtepmjpjpnnkwyykyhgpel")]
    [InlineData("ovmqkwtujqmfkao", 52, "ovmqkwtujqmfkao")]
    [InlineData("mvklahvjcnbwqvtutmfafkwiuagjkzmzwgf", 7, "tcrshocqjuidxcabatmhmrdpbhnqrgtgdnm")]
    [InlineData("kjwmntauvjjnmsagwgawkagfuaugjhawgnawgjhawjgawbfawghesh", 15, "zylbcipjkyycbhpvlvplzpvujpjvywplvcplvywplyvplquplvwthw")]
    public void TestCaesarCypherEncryptorFast(string input, int key, string expectedResult)
    {
        var result = CaesarCypherEncryptor.CaesarCypherEncryptorFast(input, key);
        Assert.Equal(expectedResult, result);
    }
}