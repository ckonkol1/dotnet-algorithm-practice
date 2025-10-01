using Arrays.Easy;

namespace ArraysUnitTests.Easy;

public class NonConstructilbleChangeUnitTests
{
    [Theory]
    [MemberData(nameof(GetNonConstructibleChangeData))]
    public void TestNonConstructibleChangeFast(int[] array, int expectedResult)
    {
        var result = NonConstructilbleChange.NonConstructibleChangeFast(array);
        Assert.Equal(expectedResult, result);
    }

    public static TheoryData<int[], int> GetNonConstructibleChangeData
    {
        get
        {
            var data = new TheoryData<int[], int>
            {
                { [5, 7, 1, 1, 2, 3, 22], 20 },
                { [1, 1, 1, 1, 1], 6 },
                { [1, 5, 1, 1, 1, 10, 15, 20, 100], 55 },
                { [6, 4, 5, 1, 1, 8, 9], 3 },
                { [], 1 },
                { [87], 1 },
                { [5, 6, 1, 1, 2, 3, 4, 9], 32 },
                { [5, 6, 1, 1, 2, 3, 43], 19 },
                { [1, 1], 3 },
                { [2], 1 },
                { [1], 2 },
                { [109, 2000, 8765, 19, 18, 17, 16, 8, 1, 1, 2, 4], 87 },
                { [1, 2, 3, 4, 5, 6, 7], 29 },
            };
            return data;
        }
    }
}