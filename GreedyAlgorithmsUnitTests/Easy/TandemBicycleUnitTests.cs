using GreedyAlgorithms.Easy;

namespace GreedyAlgorithmsUnitTests.Easy;

public class TandemBicycleUnitTests
{
    [Theory]
    [MemberData(nameof(GetTandemBicycleData))]
    public void TestGetGetTandemBicycleSpeed(int[] redShirts, int[] blueShirts, bool fastest, int expectedResult)
    {
        var result = TandemBicycle.GetTandemBicycleSpeed(redShirts, blueShirts, fastest);
        Assert.Equivalent(expectedResult, result);
    }

    public static TheoryData<int[], int[], bool, int> GetTandemBicycleData
    {
        get
        {
            var data = new TheoryData<int[], int[], bool, int>
            {
                { [5, 5, 3, 9, 2], [3, 6, 7, 2, 1], true, 32 },
                { [1, 1, 1], [1, 1, 1], true, 3 },
                { [1, 1, 1], [1, 1, 1], false, 3 },
                { [2, 4, 1], [3, 5, 2], true, 12 },
                { [2, 4, 1], [3, 5, 2], false, 10 },
                { [0, 0, 0], [0, 0, 0], true, 0 },
                { [0, 0, 0], [0, 0, 0], false, 0 },
                { [10, 10, 10], [1, 1, 1], true, 30 },
                { [10, 10, 10], [1, 1, 1], false, 30 },
                { [5, 3, 9, 2, 7], [3, 6, 7, 2, 1], true, 34 },
                { [5, 3, 9, 2, 7], [3, 6, 7, 2, 1], false, 26 },
            };
            return data;
        }
    }
}