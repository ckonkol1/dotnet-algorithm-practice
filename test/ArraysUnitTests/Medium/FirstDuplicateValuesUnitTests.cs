using Arrays.Medium;

namespace ArraysUnitTests.Medium;

public class FirstDuplicateValuesUnitTests
{
    [Theory]
    [MemberData(nameof(GetFirstDuplicateValuesData))]
    public void TestArrayOfProductsFast(int[] array, int expectedResult)
    {
        var result = FirstDuplicateValue.FirstDuplicateValueSlow(array);
        Assert.Equal(expectedResult, result);
    }


    [Theory]
    [MemberData(nameof(GetFirstDuplicateValuesData))]
    public void TestArrayOfProductsWithDictionary(int[] array, int expectedResult)
    {
        var result = FirstDuplicateValue.FirstDuplicateValueWithDictionary(array);
        Assert.Equal(expectedResult, result);
    }

    public static IEnumerable<object[]> GetFirstDuplicateValuesData
    {
        get
        {
            var data = new List<object[]>
            {
                new object[] { new[] { 2, 1, 5, 2, 3, 3, 4 }, 2 },
                new object[] { new[] { 2, 1, 5, 3, 3, 2, 4 }, 3 },
                new object[] { new[] { 3, 1, 3, 1, 1, 4, 4 }, 3 },
                new object[] { new[] { 1, 1, 2, 3, 3, 2, 2 }, 1 },
                new object[] { new int[] { }, -1 },
                new object[] { new[] { 1 }, -1 },
                new object[] { new[] { 1, 1 }, 1 },
                new object[] { new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10 }, 10 },
                new object[] { new[] { 2, 1, 1 }, 1 },
                new object[] { new[] { 2, 2, 2, 2, 2, 2, 2, 2, 2 }, 2 },
            };
            return data;
        }
    }
}