using Arrays.Medium;

namespace ArraysUnitTests.Medium;

public class ArrayOfProductsUnitTests
{
    [Theory]
    [MemberData(nameof(GetArrayOfProductsData))]
    public void TestArrayOfProductsSlow(int[] array, int[] expectedResult)
    {
        var result = ArrayOfProducts.ArrayOfProductsSlow(array);
        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [MemberData(nameof(GetArrayOfProductsData))]
    public void TestArrayOfProductsFast(int[] array, int[] expectedResult)
    {
        var result = ArrayOfProducts.ArrayOfProductsFast(array);
        Assert.Equal(expectedResult, result);
    }

    public static IEnumerable<object[]> GetArrayOfProductsData
    {
        get
        {
            var data = new List<object[]>
            {
                new object[] { new[] { 5, 1, 4, 2 }, new[] { 8, 40, 10, 20 } },
                new object[] { new[] { 1, 8, 6, 2, 4 }, new[] { 384, 48, 64, 192, 96 } },
                new object[] { new[] { -5, 2, -4, 14, -6 }, new[] { 672, -1680, 840, -240, 560 } },
                new object[] { new[] { 9, 3, 2, 1, 9, 5, 3, 2 }, new[] { 1620, 4860, 7290, 14580, 1620, 2916, 4860, 7290 } },
                new object[] { new[] { 4, 4 }, new[] { 4, 4 } },
                new object[] { new[] { 0, 0, 0, 0 }, new[] { 0, 0, 0, 0 } },
                new object[] { new[] { 1, 1, 1, 1 }, new[] { 1, 1, 1, 1 } },
                new object[] { new[] { -1, -1, -1 }, new[] { 1, 1, 1 } },
                new object[] { new[] { -1, -1, -1, -1 }, new[] { -1, -1, -1, -1 } },
                new object[] { new[] { 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 } },
                new object[] { new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, new[] { 362880, 0, 0, 0, 0, 0, 0, 0, 0, 0 } }
            };
            return data;
        }
    }
}