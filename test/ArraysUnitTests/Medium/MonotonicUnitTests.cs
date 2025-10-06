using Arrays.Medium;

namespace ArraysUnitTests.Medium;

public class MonotonicUnitTests
{
    [Theory]
    [MemberData(nameof(GetMonotonicData))]
    public void TestMonotonic(int[] array, bool expectedResult)
    {
        var result = Monotonic.IsMonotonic(array);
        Assert.Equal(expectedResult, result);
    }

    public static TheoryData<int[], bool> GetMonotonicData
    {
        get
        {
            var data = new TheoryData<int[], bool>
            {
                { [-1, -5, -10, -1100, -1100, -1101, -1102, -9001], true },
                { [], true },
                { [1], true },
                { [1, 2], true },
                { [2, 1], true },
                { [1, 5, 10, 1100, 1101, 1102, 9001], true },
                { [-1, -5, -10, -1100, -1101, -1102, -9001], true },
                { [-1, -5, -10, -1100, -900, -1101, -1102, -9001], false },
                { [1, 2, 0], false },
                { [1, 1, 2, 3, 4, 5, 5, 5, 6, 7, 8, 7, 9, 10, 1], false },
                { [1, 1, 2, 3, 4, 5, 5, 5, 6, 7, 8, 8, 9, 10, 11], true },
                { [-1, -1, -2, -3, -4, -5, -5, -5, -6, -7, -8, -7, -9, -10, -11], false },
                { [-1, -1, -2, -3, -4, -5, -5, -5, -6, -7, -8, -8, -9, -10, -11], true },
                { [-1, -1, -1, -1, -1, -1, -1, -1], true },
                { [1, 2, -1, -2, -5], false },
                { [-1, -5, 10], false },
                { [2, 2, 2, 1, 4, 5], false },
                { [1, 1, 1, 2, 3, 4, 1], false },
                { [1, 2, 3, 3, 2, 1], false },
            };
            return data;
        }
    }
}