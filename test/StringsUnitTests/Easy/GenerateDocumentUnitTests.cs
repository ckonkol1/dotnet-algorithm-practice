using Strings.Easy;

namespace StringsUnitTests.Easy;

public class GenerateDocumentUnitTests
{
    [Theory]
    [InlineData("Bste!hetsi ogEAxpelrt x ", "AlgoExpert is the Best!", true)]
    [InlineData("A", "a", false)]
    [InlineData("a", "a", true)]
    [InlineData("a hsgalhsa sanbjksbdkjba kjx", "", true)]
    [InlineData(" ", "hello", false)]
    [InlineData("     ", "     ", true)]
    [InlineData("aheaollabbhb", "hello", true)]
    [InlineData("aheaolabbhb", "hello", false)]
    [InlineData("estssa", "testing", false)]
    [InlineData("Bste!hetsi ogEAxpert", "AlgoExpert is the Best!", false)]
    [InlineData("helloworld ", "hello wOrld", false)]
    [InlineData("helloworldO", "hello wOrld", false)]
    [InlineData("helloworldO ", "hello wOrld", true)]
    [InlineData("&*&you^a%^&8766 _=-09     docanCMakemthisdocument", "Can you make this document &", true)]
    [InlineData("abcabcabcacbcdaabc", "bacaccadac", true)]
    public void TestGenerateDocumentsFast(string characters, string document, bool expectedResult)
    {
        var result = GenerateDocument.GenerateDocumentFast(characters, document);
        Assert.Equal(expectedResult, result);
    }
}