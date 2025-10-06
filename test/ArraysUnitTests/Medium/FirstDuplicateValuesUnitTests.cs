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

    public static TheoryData<int[], int> GetFirstDuplicateValuesData
    {
        get
        {
            var data = new TheoryData<int[], int>();
            data.Add([2, 1, 5, 2, 3, 3, 4], 2);
            data.Add([2, 1, 5, 3, 3, 2, 4], 3);
            data.Add([3, 1, 3, 1, 1, 4, 4], 3);
            data.Add([1, 1, 2, 3, 3, 2, 2], 1);
            data.Add([], -1);
            data.Add([1], -1);
            data.Add([1, 1], 1);
            data.Add([1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10], 10);
            data.Add([2, 1, 1], 1);
            data.Add([2, 2, 2, 2, 2, 2, 2, 2, 2], 2);
            return data;
        }
    }
}