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

    public static IEnumerable<object[]> GetMonotonicData
    {
        get
        {
            var data = new List<object[]>
            {
                new object[] { new[] { -1, -5, -10, -1100, -1100, -1101, -1102, -9001 }, true },
                new object[] { new int[] { }, true },
                new object[] { new[] { 1 }, true },
                new object[] { new[] { 1, 2 }, true },
                new object[] { new[] { 2, 1 }, true },
                new object[] { new[] { 1, 5, 10, 1100, 1101, 1102, 9001 }, true },
                new object[] { new[] { -1, -5, -10, -1100, -1101, -1102, -9001 }, true },
                new object[] { new[] { -1, -5, -10, -1100, -900, -1101, -1102, -9001 }, false },
                new object[] { new[] { 1, 2, 0 }, false },
                new object[] { new[] { 1, 1, 2, 3, 4, 5, 5, 5, 6, 7, 8, 7, 9, 10, 1 }, false },
                new object[] { new[] { 1, 1, 2, 3, 4, 5, 5, 5, 6, 7, 8, 8, 9, 10, 11 }, true },
                new object[] { new[] { -1, -1, -2, -3, -4, -5, -5, -5, -6, -7, -8, -7, -9, -10, -11 }, false },
                new object[] { new[] { -1, -1, -2, -3, -4, -5, -5, -5, -6, -7, -8, -8, -9, -10, -11 }, true },
                new object[] { new[] { -1, -1, -1, -1, -1, -1, -1, -1 }, true },
                new object[] { new[] { 1, 2, -1, -2, -5 }, false },
                new object[] { new[] { -1, -5, 10 }, false },
                new object[] { new[] { 2, 2, 2, 1, 4, 5 }, false },
                new object[] { new[] { 1, 1, 1, 2, 3, 4, 1 }, false },
                new object[] { new[] { 1, 2, 3, 3, 2, 1 }, false },
            };
            return data;
        }
    }
}