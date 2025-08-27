using Arrays.Easy;

namespace ArraysUnitTests.Easy;

public class SortedSquaredArrayUnitTests
{
    [Theory]
    [MemberData(nameof(GetSortedSquaredArrayData))]
    public void TestValidateSubsequenceSlow(int[] array, int[] expectedResult)
    {
        var result = SortedSquaredArray.SortedSquaredArraySlow(array);
        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [MemberData(nameof(GetSortedSquaredArrayData))]
    public void TestValidateSubsequenceFast(int[] array, int[] expectedResult)
    {
        var result = SortedSquaredArray.SortedSquaredArrayFast(array);
        Assert.Equal(expectedResult, result);
    }

    public static IEnumerable<object[]> GetSortedSquaredArrayData
    {
        get
        {
            var data = new List<object[]>
            {
                new object[] { new[] { 1, 2, 3, 5, 6, 8, 9 }, new[] { 1, 4, 9, 25, 36, 64, 81 } },
                new object[] { new[] { 1 }, new[] { 1 } },
                new object[] { new[] { 1, 2 }, new[] { 1, 4 } },
                new object[] { new[] { 1, 2, 3, 4, 5 }, new[] { 1, 4, 9, 16, 25 } },
                new object[] { new[] { 0 }, new[] { 0 } },
                new object[] { new[] { 10 }, new[] { 100 } },
                new object[] { new[] { -1 }, new[] { 1 } },
                new object[] { new[] { -2, -1 }, new[] { 1, 4 } },
                new object[] { new[] { -5, -4, -3, -2, -1 }, new[] { 1, 4, 9, 16, 25 } },
                new object[] { new[] { -10 }, new[] { 100 } },
                new object[] { new[] { -10, -5, 0, 5, 10 }, new[] { 0, 25, 25, 100, 100 } },
                new object[] { new[] { -7, -3, 1, 9, 22, 30 }, new[] { 1, 9, 49, 81, 484, 900 } },
                new object[] { new[] { -50, -13, -2, -1, 0, 0, 1, 1, 2, 3, 19, 20 }, new[] { 0, 0, 1, 1, 1, 4, 4, 9, 169, 361, 400, 2500 } },
                new object[] { new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 } },
                new object[] { new[] { -1, -1, 2, 3, 3, 3, 4 }, new[] { 1, 1, 4, 9, 9, 9, 16 } },
                new object[] { new[] { -3, -2, -1 }, new[] { 1, 4, 9 } },
            };
            return data;
        }
    }
}