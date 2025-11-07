using Arrays.Medium;

namespace ArraysUnitTests.Medium;

public class BestSeatUnitTests
{
    [Theory]
    [MemberData(nameof(GetData))]
    public void TestBestSeat(int[] array, int expectedResult)
    {
        var result = BestSeat.GetBestSeat(array);
        Assert.Equal(expectedResult, result);
    }

    public static TheoryData<int[], int> GetData
    {
        get
        {
            var data = new TheoryData<int[], int>();
            {
                data.Add([1, 0, 1, 0, 0, 1], 3);
                data.Add([1, 0, 0, 0, 1, 0, 1], 2);
                data.Add([1, 1, 1, 1, 1], -1);
                data.Add([1, 0, 1, 0, 0, 0, 1, 0, 1], 4);
                data.Add([1, 1, 0, 0, 1, 0, 0, 1], 2);
                data.Add([1, 0, 0, 0, 1], 2);
                data.Add([1, 0, 0, 1], 1);
                data.Add([1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1], 4);
            }
            return data;
        }
    }
}