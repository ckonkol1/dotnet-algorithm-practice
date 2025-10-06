using Arrays.Medium;

namespace ArraysUnitTests.Medium;

public class LongestPeakUnitTests
{
    [Theory]
    [MemberData(nameof(GetLongestPeakData))]
    public void TestLongestPeak(int[] array, int expectedResult)
    {
        var result = LongestPeak.LongestPeakFast(array);
        Assert.Equal(expectedResult, result);
    }

    public static TheoryData<int[], int> GetLongestPeakData
    {
        get
        {
            var data = new TheoryData<int[], int>
            {
                { [1, 2, 3, 3, 4, 0, 10, 6, 5, -1, -3, 2, 3], 6 },
                { [], 0 },
                { [1, 3, 2], 3 },
                { [1, 2, 3, 4, 5, 1], 6 },
                { [5, 4, 3, 2, 1, 2, 1], 3 },
                { [5, 4, 3, 2, 1, 2, 10, 12, -3, 5, 6, 7, 10], 5 },
                { [5, 4, 3, 2, 1, 2, 10, 12], 0 },
                { [1, 2, 3, 4, 5, 6, 10, 100, 1000], 0 },
                { [1, 2, 3, 3, 2, 1], 0 },
                { [1, 1, 3, 2, 1], 4 },
                { [1, 2, 3, 2, 1, 1], 5 },
                { [1, 1, 1, 2, 3, 10, 12, -3, -3, 2, 3, 45, 800, 99, 98, 0, -1, -1, 2, 3, 4, 5, 0, -1, -1], 9 },
                { [1, 2, 3, 3, 4, 0, 10], 3 }
            };
            return data;
        }
    }
}