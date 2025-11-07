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

    public static TheoryData<int[], int[]> GetArrayOfProductsData
    {
        get
        {
            var data = new TheoryData<int[], int[]>();
            {
                data.Add([5, 1, 4, 2], [8, 40, 10, 20]);
                data.Add([1, 8, 6, 2, 4], [384, 48, 64, 192, 96]);
                data.Add([-5, 2, -4, 14, -6], [672, -1680, 840, -240, 560]);
                data.Add([9, 3, 2, 1, 9, 5, 3, 2], [1620, 4860, 7290, 14580, 1620, 2916, 4860, 7290]);
                data.Add([4, 4], [4, 4]);
                data.Add([0, 0, 0, 0], [0, 0, 0, 0]);
                data.Add([1, 1, 1, 1], [1, 1, 1, 1]);
                data.Add([-1, -1, -1], [1, 1, 1]);
                data.Add([-1, -1, -1, -1], [-1, -1, -1, -1]);
                data.Add([0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9], [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0]);
                data.Add([0, 1, 2, 3, 4, 5, 6, 7, 8, 9], [362880, 0, 0, 0, 0, 0, 0, 0, 0, 0]);
            }
            ;
            return data;
        }
    }
}