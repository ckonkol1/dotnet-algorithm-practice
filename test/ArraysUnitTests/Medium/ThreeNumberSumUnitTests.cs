using Arrays.Medium;

namespace ArraysUnitTests.Medium;

public class ThreeNumberSumUnitTests
{
    [Theory]
    [MemberData(nameof(GetThreeNumberSumData))]
    public void TestThreeNumberSumFast(int[] array, int targetSum, List<int[]> expectedResult)
    {
        var result = ThreeNumberSum.ThreeNumberSumFast(array, targetSum);
        Assert.Equal(expectedResult, result);
    }

    public static TheoryData<int[], int, List<int[]>> GetThreeNumberSumData
    {
        get
        {
            var data = new TheoryData<int[], int, List<int[]>>
            {
                { [12, 3, 1, 2, -6, 5, -8, 6], 0, new List<int[]> { new[] { -8, 2, 6 }, new[] { -8, 3, 5 }, new[] { -6, 1, 5 } } },
#pragma warning disable CA1861
                { [1, 2, 3], 6, new List<int[]> { new[] { 1, 2, 3 } } },
#pragma warning restore CA1861
                { [1, 2, 3], 7, new List<int[]> { } },
                { [8, 10, -2, 49, 14], 57, new List<int[]> { new[] { -2, 10, 49 } } },
                { [12, 3, 1, 2, -6, 5, 0, -8, -1], 0, new List<int[]> { new[] { -8, 3, 5 }, new[] { -6, 1, 5 }, new[] { -1, 0, 1 } } },
                { [12, 3, 1, 2, -6, 5, 0, -8, -1, 6], 0, new List<int[]> { new[] { -8, 2, 6 }, new[] { -8, 3, 5 }, new[] { -6, 0, 6 }, new[] { -6, 1, 5 }, new[] { -1, 0, 1 } } },
                {
                    [12, 3, 1, 2, -6, 5, 0, -8, -1, 6, -5], 0,
                    new List<int[]> { new[] { -8, 2, 6 }, new[] { -8, 3, 5 }, new[] { -6, 0, 6 }, new[] { -6, 1, 5 }, new[] { -5, -1, 6 }, new[] { -5, 0, 5 }, new[] { -5, 2, 3 }, new[] { -1, 0, 1 } }
                },
                {
                    [1, 2, 3, 4, 5, 6, 7, 8, 9, 15], 18, new List<int[]> { new[] { 1, 2, 15 }, new[] { 1, 8, 9 }, new[] { 2, 7, 9 }, new[] { 3, 6, 9 }, new[] { 3, 7, 8 }, new[] { 4, 5, 9 }, new[] { 4, 6, 8 }, new[] { 5, 6, 7 } }
                },
                { [1, 2, 3, 4, 5, 6, 7, 8, 9, 15], 32, [new[] { 8, 9, 15 }] },
                { [1, 2, 3, 4, 5, 6, 7, 8, 9, 15], 33, new List<int[]> { } },
                { [1, 2, 3, 4, 5, 6, 7, 8, 9, 15], 5, new List<int[]> { } },
            };
            return data;
        }
    }
}