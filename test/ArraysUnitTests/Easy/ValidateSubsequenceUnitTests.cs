using Arrays.Easy;

namespace ArraysUnitTests.Easy;

public class ValidateSubsequenceUnitTests
{
    [Theory]
    [MemberData(nameof(GetValidateSubsequenceData))]
    public void TestValidateSubsequence(List<int> array, List<int> sequence, bool expectedResult)
    {
        var result = ValidateSubsequence.IsValidSubsequence(array, sequence);
        Assert.Equal(expectedResult, result);
    }

    public static IEnumerable<object[]> GetValidateSubsequenceData
    {
        get
        {
            var data = new List<object[]>
            {
                new object[] { new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 }, new List<int> { 1, 6, -1, 10 }, true },
                new object[]
                {
                    new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 }, new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 }, true
                },
                new object[]
                    { new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 }, new List<int> { 5, 1, 22, 6, -1, 8, 10 }, true },
                new object[] { new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 }, new List<int> { 22, 25, 6 }, true },
                new object[] { new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 }, new List<int> { 1, 6, 10 }, true },
                new object[] { new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 }, new List<int> { 5, 1, 22, 10 }, true },
                new object[] { new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 }, new List<int> { 5, -1, 8, 10 }, true },
                new object[] { new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 }, new List<int> { 25 }, true },
                new object[] { new List<int> { 1, 1, 1, 1, 1 }, new List<int> { 1, 1, 1, 1, 1 }, true },
                new object[]
                {
                    new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 }, new List<int> { 5, 1, 22, 25, 6, -1, 8, 10, 12 },
                    false
                },
                new object[]
                {
                    new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 }, new List<int> { 4, 5, 1, 22, 25, 6, -1, 8, 10 }, false
                },
                new object[]
                {
                    new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 }, new List<int> { 5, 1, 22, 22, 25, 6, -1, 8, 10 },
                    false
                },
                new object[]
                {
                    new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 }, new List<int> { 5, 1, 22, 22, 6, -1, 8, 10 }, false
                },
                new object[] { new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 }, new List<int> { 1, 6, -1, -1 }, false },
                new object[]
                    { new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 }, new List<int> { 1, 6, -1, -1, 10 }, false },
                new object[] { new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 }, new List<int> { 1, 6, -1, -2 }, false },
                new object[] { new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 }, new List<int> { 26 }, false },
                new object[]
                {
                    new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 }, new List<int> { 5, 1, 25, 22, 6, -1, 8, 10 }, false
                },
                new object[] { new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 }, new List<int> { 5, 26, 22, 8 }, false },
                new object[] { new List<int> { 1, 1, 6, 1 }, new List<int> { 1, 1, 1, 6 }, false },
                new object[]
                {
                    new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 }, new List<int> { 1, 6, -1, 10, 11, 11, 11, 11 }, false
                },
                new object[]
                {
                    new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 }, new List<int> { 5, 1, 22, 25, 6, -1, 8, 10, 10 },
                    false
                },
                new object[] { new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 }, new List<int> { 1, 6, -1, 5 }, false },
            };
            return data;
        }
    }
}