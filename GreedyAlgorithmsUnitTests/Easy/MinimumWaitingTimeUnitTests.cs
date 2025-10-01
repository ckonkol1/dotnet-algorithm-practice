using GreedyAlgorithms.Easy;

namespace GreedyAlgorithmsUnitTests.Easy;

public class MinimumWaitingTimeUnitTests
{
    [Theory]
    [MemberData(nameof(GetMinimumWaitingTimeData))]
    public void TestGetMinimumWaitingTime(int[] array, int expectedResult)
    {
        var result = MinimumWaitingTime.GetMinimumWaitingTime(array);
        Assert.Equivalent(expectedResult, result);
    }

    public static TheoryData<int[], int> GetMinimumWaitingTimeData =>
        new()
        {
            { [3, 2, 1, 2, 6], 17 },
            { [1, 2, 3, 4, 5], 20 },
            { [5, 4, 3, 2, 1], 20 },
            { [1], 0 },
            { [2, 1, 1, 1], 6 },
            { [7, 9, 2, 3], 19 }
        };
}