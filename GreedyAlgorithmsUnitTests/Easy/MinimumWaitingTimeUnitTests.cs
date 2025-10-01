using GreedyAlgorithms.Easy;

namespace GreedyAlgorithmsUnitTests.Easy;

public class MinimumWaitingTimeUnitTests
{
    [Theory]
    [MemberData(nameof(GetMinimumWaitingTimeData))]
    public void TestGetMinimumWaitingTimeData(int[] array, int expectedResult)
    {
        var result = MinimumWaitingTime.GetMinimumWaitingTime(array);
        Assert.Equivalent(expectedResult, result);
    }

    public static IEnumerable<object[]> GetMinimumWaitingTimeData
    {
        get
        {
            var data = new List<object[]>
            {
                new object[]
                {
                    new[] { 3, 2, 1, 2, 6 },
                    17
                },
                new object[]
                {
                    new[] { 1, 2, 3, 4, 5 },
                    20
                },
                new object[]
                {
                    new[] { 5, 4, 3, 2, 1 },
                    20
                },
                new object[]
                {
                    new[] { 1 },
                    0
                },
                new object[]
                {
                    new[] { 2, 1, 1, 1 },
                    6
                },
                new object[]
                {
                    new[] { 7, 9, 2, 3 },
                    19
                }
            };
            return data;
        }
    }
}